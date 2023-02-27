/* Grigoris Karaoglanian - p16044 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle
{
    class Data
    {

        public void writeFile(User user)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("../../Resources/users.txt", true))
            {
                foreach (String u in readAllUsers())
                {
                    if (userFormat(u).username == user.username && userFormat(u).record >= user.record)
                    {
                        return;
                    }
                }
                file.WriteLine(strFormatUser(user));
            }
        }

       public List<String> readAllUsers()
        {
            List<String> usersList = new List<string>();
            try
            {
                foreach (String line in System.IO.File.ReadAllLines("../../Resources/users.txt"))
                {
                    usersList.Add(line);
                }
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return usersList;
        }

        private String strFormatUser(User user)
        {
            String strUser = String.Format("{0}\t{1}", user.username, user.record);
            return strUser;
        }

        public User userFormat(String strItem)
        {
            // Warning! Only works to reverse strFormatUser
            User user = new User();
            string[] ul = strItem.Split('\t');
            user.username = ul[0];
            user.record = int.Parse(ul[1]);
            return user;
        }
    }
}
