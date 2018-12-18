﻿namespace VLibrarian
{
   public interface I_NewLogin
    {
        //interface object, through which we will be accessing the controller class methods
        //iskelti + constructor + dependency injection
        //public I_NewLogin L_or_S
        //{
        //    get;
        //    set;
        //} 

        string login(string username, string pass);
        string signup(string username, string pass,
                                    string name, string surname, string birth, string email);
        int inputCheck(string whatToCheck, int c);
        bool checkIfExistsInDBUsers(string whatToLookFor);
        


    }
}