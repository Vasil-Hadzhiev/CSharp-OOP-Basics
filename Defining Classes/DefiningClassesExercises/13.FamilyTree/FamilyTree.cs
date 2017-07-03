using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.FamilyTree
{
    public class FamilyTree
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var family = new List<Person>();

            var linkedMembers = new List<string>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                if (inputLine.Contains('-'))
                {
                    linkedMembers.Add(inputLine);
                }
                else
                {
                    var index = inputLine.LastIndexOf(' ');
                    var name = inputLine.Substring(0, index);
                    var birthday = inputLine.Substring(index + 1);
                    var person = new Person(name, birthday);
                    family.Add(person);
                }
            }

            foreach (var memberInfo in linkedMembers)
            {
                var tokens = Regex.Split(memberInfo, " - ");

                Person parent;
                Person child;

                if (tokens[0].Contains('/') && tokens[1].Contains('/'))
                {
                    var parentBirthday = tokens[0];
                    var childBirthday = tokens[1];

                    parent = family.
                        First(p => p.Birthday == parentBirthday);

                    child = family.
                        First(c => c.Birthday == childBirthday);
                }
                else if (tokens[0].Contains('/') || tokens[1].Contains('/'))
                {
                    var name = string.Empty;
                    var birthday = string.Empty;

                    if (tokens[0].Contains('/'))
                    {
                        name = tokens[1];
                        birthday = tokens[0];

                        parent = family.
                            First(p => p.Birthday == birthday);

                        child = family.
                            First(c => c.Name == name);
                    }
                    else
                    {
                        name = tokens[0];
                        birthday = tokens[1];

                        parent = family.
                            First(p => p.Name == name);

                        child = family.
                            First(c => c.Birthday == birthday);
                    }
                }
                else
                {
                    var parentName = tokens[0];
                    var childName = tokens[1];

                    parent = family.
                            First(p => p.Name == parentName);

                    child = family.
                        First(c => c.Name == childName);
                }

                if (!parent.Children.Contains(child))
                {
                    parent.Children.Add(child);
                }

                if (!child.Parents.Contains(parent))
                {
                    child.Parents.Add(parent);
                }
            }

            Person mainPerson;

            if (input.Contains('/'))
            {
                mainPerson = family.
                    First(p => p.Birthday == input);
            }
            else
            {
                mainPerson = family.
                    First(p => p.Name == input);
            }

            Console.WriteLine(mainPerson.ToString());
            Console.WriteLine("Parents:");
            foreach (var parent in mainPerson.Parents)
            {
                Console.WriteLine(parent.ToString());
            }
            Console.WriteLine("Children:");
            foreach (var child in mainPerson.Children)
            {
                Console.WriteLine(child.ToString());
            }
        }
    }
}
