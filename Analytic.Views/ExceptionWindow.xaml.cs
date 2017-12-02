using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Analytic.Views
{
    /// <summary>
    /// Interaktionslogik für ExceptionWindow.xaml
    /// </summary>
    public partial class ExceptionWindow : Window
    {
        public ExceptionWindow(Exception ex)
        {
            InitializeComponent();

            if (ex == null) return;

            ErrorMsg.Content = ex.Message;
            ErrorDetails.Text = TranslateStack(ex);

        }
        private string TranslateStack(Exception exception)
        {
            //string format = "{0};{1};{2};{3};{4}";
            string format = "{0}\t{1}\t{2}\t{3}\t{4}";
            StringBuilder builder = new StringBuilder();
            StackTrace trace = new StackTrace(exception, true);
            var stackFrames = trace.GetFrames();
            if (stackFrames == null) return builder.ToString();
            foreach (StackFrame frame in stackFrames)
            {
                string name = frame.GetMethod().Name;
                StringBuilder subBuilder = new StringBuilder();
                string fileName = frame.GetFileName();
                string str = frame.GetFileLineNumber().ToString(CultureInfo.InvariantCulture);
                if ((frame.GetMethod() == null) || (frame.GetMethod().DeclaringType == null)) continue;
                string fullName = frame.GetMethod().DeclaringType.FullName;
                foreach (ParameterInfo info in frame.GetMethod().GetParameters())
                {
                    if (subBuilder.Length != 0)
                    {
                        subBuilder.Append(", ");
                    }
                    subBuilder.Append(info.ParameterType.Name + " " + info.Name);
                }
                if (builder.Length != 0)
                {
                    builder.Append("\r\n");
                }
                builder.AppendFormat(CultureInfo.CurrentCulture, format, new object[] { name, subBuilder, fullName, fileName, str });
            }
            return builder.ToString();
        }

    }
}
