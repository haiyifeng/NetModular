﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 16.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace NetModular.Module.CodeGenerator.Infrastructure.Templates.Default.T4.src.Library.Application
{
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ServiceInterface : ServiceInterfaceBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("using System;\r\nusing System.Threading.Tasks;\r\nusing ");
            
            #line 4 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write(".Lib.Utils.Result;\r\nusing ");
            
            #line 5 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write(".Module.");
            
            #line 5 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Project.Code));
            
            #line default
            #line hidden
            this.Write(".Application.");
            
            #line 5 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write("Service.ViewModels;\r\nusing ");
            
            #line 6 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write(".Module.");
            
            #line 6 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Project.Code));
            
            #line default
            #line hidden
            this.Write(".Domain.");
            
            #line 6 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write(".Models;\r\n\r\nnamespace ");
            
            #line 8 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_prefix));
            
            #line default
            #line hidden
            this.Write(".Module.");
            
            #line 8 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_model.Project.Code));
            
            #line default
            #line hidden
            this.Write(".Application.");
            
            #line 8 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write("Service\r\n{\r\n    /// <summary>\r\n    /// ");
            
            #line 11 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Remarks));
            
            #line default
            #line hidden
            this.Write("服务\r\n    /// </summary>\r\n    public interface I");
            
            #line 13 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write("Service\r\n    {\r\n        /// <summary>\r\n        /// 查询\r\n        /// </summary>\r\n  " +
                    "      /// <param name=\"model\"></param>\r\n        /// <returns></returns>\r\n       " +
                    " Task<IResultModel> Query(");
            
            #line 20 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write("QueryModel model);\r\n\r\n        /// <summary>\r\n        /// 创建\r\n        /// </summar" +
                    "y>\r\n        /// <param name=\"model\"></param>\r\n        /// <returns></returns>\r\n " +
                    "       Task<IResultModel> Add(");
            
            #line 27 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write("AddModel model);\r\n\r\n        /// <summary>\r\n        /// 删除\r\n        /// </summary>" +
                    "\r\n        /// <param name=\"id\">编号</param>\r\n        /// <returns></returns>\r\n    " +
                    "    Task<IResultModel> Delete(");
            
            #line 34 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.PrimaryKeyTypeName));
            
            #line default
            #line hidden
            this.Write(" id);\r\n\r\n        /// <summary>\r\n        /// 编辑\r\n        /// </summary>\r\n        /" +
                    "// <param name=\"id\"></param>\r\n        /// <returns></returns>\r\n        Task<IRes" +
                    "ultModel> Edit(");
            
            #line 41 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.PrimaryKeyTypeName));
            
            #line default
            #line hidden
            this.Write(" id);\r\n\r\n        /// <summary>\r\n        /// 修改\r\n        /// </summary>\r\n        /" +
                    "// <param name=\"model\"></param>\r\n        /// <returns></returns>\r\n        Task<I" +
                    "ResultModel> Update(");
            
            #line 48 "D:\MyProject\NetModular\src\Module\CodeGenerator\Library\Infrastructure\Templates\Default\T4\src\Library\Application\ServiceInterface.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_class.Name));
            
            #line default
            #line hidden
            this.Write("UpdateModel model);\r\n    }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class ServiceInterfaceBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
