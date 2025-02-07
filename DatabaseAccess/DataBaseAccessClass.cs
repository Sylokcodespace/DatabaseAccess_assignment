using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    public class DataBaseAccessClass
    {
        // Where the connection to database will be linked at

        // INSERT
        // INSERTS INTO table_name(column1, column2, column 3, ...)
        // VALUES(values1, values2, values3)
        public int AddAuthor(string first, string last)
        {
            string sql = "INSERT INTO Authors ";
            sql += "(FirstName, LastName)";
            sql += "VALUES ";
            sql += "(" + first + ", " + last + "}";

            int val = 0; 
            return val;
        }
        // DELETE
        // DELETE FROM table_name WHERE condition;
        // Would actually be an UPDATE SQL Statement
        public int DeleteAuthor(int id)
        {
            string sql = "DELETE FROM Authors WHERE ";
            sql += id;

            int val = 0;
            return val;
        }
        // PURGES

        // SELECT
        // SELECT column1, column 2; ...
        // SELECT *;
        // FROM table_name;
        // WHERE id = value;
        // WHERE Country - 'Mexico';
        public Authors SELECTAuthor(int id)
        {
            Authors authors = new Authors();

            string sql = "SELECT * from Authors";
            sql += "WHERE AuthorID = " + id;

            //authors.AuthorID = id; // i know im getting an error here and i will not fix it because i know it had no error eariler but now it does on my end.
            //...
            return authors;
        }
        // UPDATES 
        // UPDATES table_name
        // SET column1 = value1, column 2 = value2, ...
        // WHERE condion 
        public int UpdateAuthor(int id, string first, string last)
        {
            string sql = "UPDATE Author";
            sql += " SET ";
            sql += "FirstName = " + first + ", ";
            sql += "LastName = " + last;

            int val = 0;
            return val;
        }
        // TITLE example 
        // Select 'ABC' As title, * from ABC
        //Select 'CD' As title, * from CD
        //Select 'EN' As title, * from EN
    }
}
