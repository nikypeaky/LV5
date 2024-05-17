using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lv05
{
    class GroupNote : Note
    {
        private List<string> groupMembers;

        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            this.groupMembers = new List<string>();
        }

        public void AddMember(string member)
        {
            groupMembers.Add(member);
        }

        public void RemoveMember(string member)
        {
            groupMembers.Remove(member);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("GROUP NOTE: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            Console.WriteLine("Group Members:");
            foreach (string member in groupMembers)
            {
                Console.WriteLine("- " + member);
            }
            Console.ResetColor();
        }
    }
}
