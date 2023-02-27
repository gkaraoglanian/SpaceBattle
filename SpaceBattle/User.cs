/* Grigoris Karaoglanian - p16044 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SpaceBattle
{
    public class User
    {
        public User()
        {
            
        }
        public User(String username , int record)
        {
            this.username = username;
            this.record = record;
        }
        public string username { get; set; }
        public int record { get; set; }

        
        // ------------------------- Data Class will handle this ---------------------
        // --------------------------------- No Use ----------------------------------
        public void writeUser(User user)
        {
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(String.Format("(1).ser", user.username), FileMode.OpenOrCreate, FileAccess.Write);
            formatter.Serialize(stream, user);
            stream.Close();
        }

        public User ReadUser( User user )
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(String.Format("(1).ser", user.username), FileMode.Open, FileAccess.Read);
            user = (User)formatter.Deserialize(stream);
            stream.Close();
            return user;
        }
    }
}
