using System;
namespace getset1
{
	public class EncapClass
	{
        private int age;
        private string name;

        public void setAge(int ageFromUser)
           
        {
            age = ageFromUser;
        }
        public int getAge()
        {
            return age;
        }
        public void setName(string nameFromUser)

        {
            name = nameFromUser;
        }
        public string getName()
        {
            return name;
        }
    }
}
