using System;
using System.Collections.Generic;
using System.Text;

namespace libraryOOP
{
    class Reader
    {
        private string _name;
        private string _surname;
        private string _middleName;
        private string _phone;

        private int _levelReader;

        public int GetLevelReader()
        {
            return _levelReader;
        }
    }
}
