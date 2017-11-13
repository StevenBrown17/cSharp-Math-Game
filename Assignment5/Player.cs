using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Player {

        /// <summary>
        /// holds players name
        /// </summary>
        private String name;
        /// <summary>
        /// holds players age
        /// </summary>
        private int age;

        /// <summary>
        /// empty constructor
        /// </summary>
        public Player() { }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Player(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public String getName() { return this.name; }
        public void setName(String name) { this.name = name; }

        public int getAge() { return this.age; }
        public void setAge(int age) { this.age = age; }


    }//end class
}//end namespace
