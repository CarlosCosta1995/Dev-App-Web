// See https://aka.ms/new-console-template for more information
/* Implementar um programa que simule o canil municipal.
• Limite de animais a acolher (considerar apenas cães e gatos)
• Permitir registar um animal acolhido
• Permitir registar a adoção de um animal */

using Simulacao_Canil_Municipal;

Canil canil1 = new Canil("Canil Municipal", 2);
Console.WriteLine("nome do canil: {0} e capacidade: {1}", canil1._nomeCanil, canil1._capacidadeMaxima);

Animal farrusco = new Animal("Farrusco", "Cão", "Grande", 1, 23);
Console.WriteLine("nome: {0}, tipo: {1}, porte: {2}, chip: {3}, peso: {4}", farrusco.Nome, farrusco.tipoAnimal, farrusco.porte, farrusco.chip, farrusco.peso);
canil1.registarAnimal(farrusco);

Animal Bobby = new Animal("Bobby", "gato", "pequeno", 2, 7);
Console.WriteLine("nome: {0}, tipo: {1}, porte: {2}, chip: {3}, peso: {4}", Bobby.Nome, Bobby.tipoAnimal, Bobby.porte, Bobby.chip, Bobby.peso);
canil1.registarAnimal(Bobby);

canil1.adotarAnimal(farrusco.chip);