﻿class Program
{
    static void OnInputTest(){
        System.Console.WriteLine("Input Received~!");
    }

   static void Main(string[] args)
   {
        InputManager inputManager = new InputManager();
        
        inputManager.InputKey += OnInputTest;
        while(true)
        {
            inputManager.Update();
        }
   }
}