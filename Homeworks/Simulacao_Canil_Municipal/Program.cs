﻿// See https://aka.ms/new-console-template for more information
/* Implementar um programa que simule o canil municipal.
• Limite de animais a acolher (considerar apenas cães e gatos)
• Permitir registar um animal acolhido
• Permitir registar a adoção de um animal */

using Simulacao_Canil_Municipal;

Dog farrusco = new Dog();
farrusco.DogName = "Farrusco";
farrusco.AddDog(farrusco.DogName);


Dog bobby = new Dog();
bobby.DogName = "Bobby";
bobby.AddDog(bobby.DogName);

farrusco.AdoptDog(farrusco);

/*
cao.AddDog("Farrusco");
//Console.WriteLine(cao.Doge[0]);
cao.AddDog("Bobby");
Console.WriteLine(cao.);
Console.WriteLine(cao.Doge[1]);


for (int i = 0; i <= 2; i++)
{
    Console.WriteLine(cao.Doge[i]);
}*/

