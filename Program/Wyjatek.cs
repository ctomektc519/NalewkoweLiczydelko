/* CREATED BY: Tomasz Cieślik
 * DATE: 14.12.2020
 * DESCRIPTION: Exception's generator.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
 public  class Wyjatek : Exception
    {
        public Wyjatek(string message) : base(message)
        {
        }
    }
}
