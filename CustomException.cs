using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEXception
{
    public class CustomException : Exception
    {





        // Enum for Exception Type

        //An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
        // it is specially declared when we have a small and specific information and we need a conatiner to store it.

        public enum ExceptionTYpe
        {
            Null_Message, Empty_Message,
            No_Such_Field, No_Such_Method,
            No_Such_class, Object_Creation_Isssue
        }

        // create a varible for enum.
        private readonly ExceptionTYpe type;


        // constructor for our class
        public CustomException(ExceptionTYpe type, string message) : base(message)
        {
            this.type = type;
        }






    }
}

