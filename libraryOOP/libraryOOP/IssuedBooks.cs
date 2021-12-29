using System;
using System.Collections.Generic;
using System.Text;

namespace libraryOOP
{
    class IssuedBooks //основной класс, тут идет связка читателя + его книги и расчет стоимости в конструкторе т.е. отдельных методов вызывать не нужно будет, однако он принимает кучу параметров что плохо
    {
        private Reader _reader = new Reader();// объекты класса читателя и книги и даты
        private Books _book = new Books();
        private DateTime _dateIssue;
        private DateTime _dateReturn;

        private int _totalPrice; //общая стоимость,срок сдачи книги(убрал), уровень испорченности книги
        //private string _rentalTimeBook;
        private int _corruptionBook;
        IssuedBooks(Reader reader, Books book, int yearIssue, int monthIssue, int dayIssue, int yearReturn, int monthReturn, int dayReturn, int corruptionBook) 
        {
            _reader = reader;//алгоритм просчета стоимости тут
            _book = book;
            _dateIssue = new DateTime(yearIssue, monthIssue, dayIssue);
            _dateReturn = new DateTime(yearReturn, monthReturn, dayReturn);

            if (yearIssue != yearReturn && yearIssue < yearReturn) _totalPrice = 100;
            else _totalPrice = monthReturn - monthIssue;

            if (_corruptionBook > 2) _totalPrice *= 3;
            if (_reader.GetLevelReader() > 3) _totalPrice /= 2;
        }
    }
}
