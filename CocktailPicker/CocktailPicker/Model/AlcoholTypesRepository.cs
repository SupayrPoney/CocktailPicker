using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CocktailPicker.Model
{
    public class AlcoholTypesRepository
    {
        private ObservableCollection<AlcoholType> bookInfo;

        public ObservableCollection<AlcoholType> AlcoholType
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }

        public AlcoholTypesRepository()
        {
            GenerateBookInfo();
        }

        internal void GenerateBookInfo()
        {
            bookInfo = new ObservableCollection<AlcoholType>();
            bookInfo.Add(new AlcoholType() { AlcoholName = "Mocktail", Description = "It is provides a useful overview of the Android application life cycle", Image = "Gin.png"});
            bookInfo.Add(new AlcoholType() { AlcoholName = "Exotic", Description = "It is provides a useful overview of the Android application life cycle", Image = "Gin.png" });
            bookInfo.Add(new AlcoholType() { AlcoholName = "Gin", Description = "Object-oriented programming is a programming paradigm based on the concept of objects", Image = "Gin.png" });
            bookInfo.Add(new AlcoholType() { AlcoholName = "Rum", Description = "Code Contracts provide a way to convey code assumptions", Image = "Rum.png" });
            bookInfo.Add(new AlcoholType() { AlcoholName = "Vodka", Description = "You’ll learn several different approaches to applying machine learning", Image = "Gin.png" });
            bookInfo.Add(new AlcoholType() { AlcoholName = "Tequila", Description = "Neural networks are an exciting field of software development", Image = "Gin.png" });
            bookInfo.Add(new AlcoholType() { AlcoholName = "Whisky", Description = "It is a powerful tool for editing code and serves for end-to-end programming", Image = "Gin.png" });
        }
    }
}
