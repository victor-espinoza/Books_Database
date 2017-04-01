//Victor Espinoza
//CECS 475 - Application Programming using .NET
//Assignment #4 - Database Entity Model
//Due: 2/23/16
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksQueries {
   public partial class BooksQueries : Form {
      public BooksQueries() {
         InitializeComponent();
      }//close constructor

      private void BooksQueries_Load(object sender, EventArgs e) {

         // Entity Framework DBContext
         BookDatabase.BooksEntities dbcontext =
          new BookDatabase.BooksEntities();

         // Get a list of all the titles and the authors who wrote them. 
         // Sort the result by title.
         var titlesAndAuthors =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby book.Title1
            select new {
               book.Title1,
               author.FirstName,
               author.LastName
            }; //end select new

         outputTextBox.AppendText("\r\n\r\nTitles and Authors (Sorted By Title):");
         // display authors and titles in tabular format
         foreach (var element in titlesAndAuthors) {
            outputTextBox.AppendText(
               String.Format("\r\n\t{0,-50} -      {1,-10} {2}",
                  element.Title1, element.FirstName, element.LastName));
         } // end foreach


         // Get a list of all the titles and the authors who wrote them. Sort the result by title. 
         // For each title sort the authors alphabetically by last name, then first name.
         var authorsAndTitles =
            from book in dbcontext.Titles
            from author in book.Authors
            orderby book.Title1, author.LastName, author.FirstName
            select new {
               book.Title1,
               author.LastName,
               author.FirstName
            }; //end select new

         outputTextBox.AppendText("\r\n\r\nAuthors and Titles With Authors Sorted for Each Title:");

         // display authors and titles in tabular format
         foreach (var element in authorsAndTitles) {
            outputTextBox.AppendText(
               String.Format("\r\n\t{0,-50} -      {1,-10} {2}",
                  element.Title1, element.FirstName, element.LastName));
         } // end foreach

         // Get a list of all the authors grouped by title, sorted by title; for a given 
         // title sort the author names alphabetically by last name first then first name.
         var authorByTitle =
            from book in dbcontext.Titles
            orderby book.Title1, book.ISBN
            select new {
               book.Title1,
               book.ISBN,
               Name =
                  (from author in book.Authors
                   orderby author.LastName, author.FirstName
                   select author.FirstName + " " + author.LastName)
            }; //end select new

         outputTextBox.AppendText("\r\n\r\nTitles grouped by author:");
         // display titles written by each author, grouped by author
         foreach (var title in authorByTitle) {
            // display Book Title's name
            outputTextBox.AppendText("\r\n\t" + title.Title1 + ":");
            // display authors who wrote that book
            foreach (var author in title.Name) {
               outputTextBox.AppendText("\r\n\t\t" + author);
            } // end inner foreach
         } // end outer foreach

      }

      private void outputTextBox_TextChanged(object sender, EventArgs e) {

      } //close void BooksQueries_Load(object sender, EventArgs e)

   } //close partial class BooksQueries

} //close namespace BooksQueries
