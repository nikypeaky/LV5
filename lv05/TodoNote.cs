using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv05
{
    class TodoNote : Note
    {
        public TodoNote(string message, ITheme theme) : base(message, theme) { }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("TODO: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.ResetColor();
        }
    }
}
