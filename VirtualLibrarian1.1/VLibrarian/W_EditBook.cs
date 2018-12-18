﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using System;

using Android.Media;
using Android.Graphics;

namespace VLibrarian
{
    [Activity(Label = "W_EditBook")]
    public class W_EditBook : Activity
    {
        //passed book
        public static Book passedBook;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.L_EditBook);

            EditText ISBN = FindViewById<EditText>(Resource.Id.textInputISBN);
            EditText Title = FindViewById<EditText>(Resource.Id.textInputTitle);
            EditText Author = FindViewById<EditText>(Resource.Id.textInputAuthor);
            EditText Quantity = FindViewById<EditText>(Resource.Id.textInputQuantity);
            CheckBox Genres = FindViewById<CheckBox>(Resource.Id.checkBoxGenres);
            EditText Description = FindViewById<EditText>(Resource.Id.textInputDescription);


            Button EditBook = FindViewById<Button>(Resource.Id.buttonEditBook);

            //display info.
            ISBN.Text = passedBook.ISBN;
            Title.Text = passedBook.title;
            Author.Text = passedBook.author;
            Quantity.Text = passedBook.quantity.ToString();
            Description.Text = passedBook.description;








            //edit
            EditBook.Click += (sender, e) =>
            {
                //get new info
                passedBook.ISBN = ISBN.Text;
                passedBook.title = Title.Text;
                passedBook.author = Author.Text;

                //check if valid quantity
                int qua;
                if (!Int32.TryParse(Quantity.Text, out qua))
                {
                    Toast.MakeText(ApplicationContext, "Please enter a valid quantity", ToastLength.Long).Show();
                    return;
                }
                passedBook.quantity = qua;
                passedBook.description = Description.Text;



                //save changes
                Controller_linker.runBookUpdate(LibrarySystem.edBook, passedBook);
                Toast.MakeText(ApplicationContext, "Changes saved", ToastLength.Long).Show();

                //exit
                Intent Exiting = new Intent(this, typeof(W_LibSys));
                this.StartActivity(Exiting);
            };
        }
    }
}