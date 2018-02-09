using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace ExcelCSX
{
    public class CsScript
    {
        public string ScriptCode { get; set; }

        public CsScript(string code)
        {
            ScriptCode = code;
        }

        public async Task<string> Execute(dynamic excel)
        {
            Func<string> executeCSharpScript = () =>
            {
                try
                {
                    var ssr = ScriptSourceResolver.Default.WithBaseDirectory(Core.Config.CurrentFolderPath);
                    var smr = ScriptMetadataResolver.Default.WithBaseDirectory(Core.Config.CurrentFolderPath);
                    var options = ScriptOptions.Default
                                         .AddReferences(
                                             Assembly.GetAssembly(typeof(System.Dynamic.DynamicObject)),  // System.Code
                                             Assembly.GetAssembly(typeof(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo)),  // Microsoft.CSharp
                                             Assembly.GetAssembly(typeof(System.Dynamic.ExpandoObject)) // System.Dynamic
                                         )
                                         .AddImports("System.Dynamic")
                                         .WithSourceResolver(ssr)
                                         .WithMetadataResolver(smr);

                    var script = CSharpScript.Create(ScriptCode, options, typeof(DynamicExcel));
                    var x = script.RunAsync(new DynamicExcel { Excel = excel });
                    x.Wait();

                    return "";
                }
                catch (CompilationErrorException e)
                {
                    return "C#Script Compilation Error :" + Environment.NewLine
                            + string.Join(Environment.NewLine, e.Diagnostics);
                }
                catch (Exception e)
                {
                    var scriptError = e.InnerException;
                    return "C#Script Execution Error : " + Environment.NewLine 
                            + scriptError.Message + Environment.NewLine
                            + Environment.NewLine 
                            + scriptError.StackTrace;
                }
            };
            return await StartSTATask(executeCSharpScript);
        }        

        /// <summary>
        /// STAThreadでTaskを立ち上げる
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static Task<T> StartSTATask<T>(Func<T> func)
        {
            var tcs = new TaskCompletionSource<T>();
            var thread = new Thread(() =>
            {
                try
                {
                    tcs.SetResult(func());
                }
                catch (Exception e)
                {
                    tcs.SetException(e);
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            return tcs.Task;
        }
    }

    public class DynamicExcel
    {
        public dynamic Excel;
    }
}