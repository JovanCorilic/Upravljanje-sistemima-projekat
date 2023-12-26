using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Xml.Linq;

namespace Zadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement xmlData = XElement.Load("C:/Users/Kssbc/source/repos/Zadatak3/Zadatak3/primer.xml");
            XElement MovieDatabase =(XElement) xmlData.FirstNode;
            XElement ListaMovies = (XElement)MovieDatabase.FirstNode;
            ImdbContext imdbContext = new ImdbContext();
            XElement DirectorDatabase = (XElement)MovieDatabase.NextNode;
            XElement listaDirector = (XElement)DirectorDatabase.FirstNode;
            
            do
            {
                Director director = new Director();
                var attribute = listaDirector.FirstAttribute;
                director.Id = int.Parse(attribute.Value);
                attribute = attribute.NextAttribute;
                director.Oscars = int.Parse(attribute.Value);
                attribute = attribute.NextAttribute;
                director.Born = attribute.Value;
                attribute = attribute.NextAttribute;
                director.Died = attribute.Value;
                director.Name = listaDirector.FirstNode.ToString();
                imdbContext.Directors.Add(director);
                
                listaDirector = (XElement)listaDirector.NextNode;
            } while (listaDirector!=null);

            do
            {
                Movie movie = new Movie();
                var attribute = ListaMovies.FirstAttribute;
                movie.Id =int.Parse(attribute.Value);
                attribute = attribute.NextAttribute;

                NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
                numberFormatInfo.NumberDecimalSeparator = ".";
                movie.Rating =Convert.ToDouble(attribute.Value,numberFormatInfo);
                attribute = attribute.NextAttribute;
                movie.Year = int.Parse(attribute.Value);
                attribute = attribute.NextAttribute;
                movie.Oscars = int.Parse(attribute.Value);
                attribute = attribute.NextAttribute;
                movie.DirectorId = int.Parse(attribute.Value);
                var vrednost = ListaMovies.FirstNode;
                movie.Title = vrednost.ToString();
                imdbContext.Movies.Add(movie);
                ListaMovies = (XElement)ListaMovies.NextNode;
            } while (ListaMovies != null );
            try
            {
                // Your code...
                // Could also be before try if you know the exception occurs in SaveChanges

                imdbContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            Dictionary<string, Movie> dict = new Dictionary<string, Movie>();
            List<string> test = new List<string>();
            
        }
    }
}
