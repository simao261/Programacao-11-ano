using System;
using System.Threading;

namespace Ficha_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating two car objects with different positions, odometers, license plates, and colors.
            Automovel automovel1 = new Automovel(0, 10, 15700, "NA-17-66", ConsoleColor.Red);
            Automovel automovel2 = new Automovel(0, 14, 5000, "AA-11-02", ConsoleColor.Green);

            // Setting the initial speeds for the cars
            automovel1.Velocidade = 3;
            automovel2.Velocidade = 4;

            // Infinite loop to animate the movement of the cars
            while (true)
            {
                // Display license plates and odometers at the top of the console
                Console.SetCursorPosition(0, 0);  // Position at the top
                Console.WriteLine($"Matricula: {automovel1.Matricula} | Quilometragem: {automovel1.Quilometragem}");

                Console.SetCursorPosition(0, 1);  // Next line
                Console.WriteLine($"Matricula: {automovel2.Matricula} | Quilometragem: {automovel2.Quilometragem}");

                Console.SetCursorPosition(0, 3); // Move to avoid overriding car display

                // Erase the previous position of both cars
                automovel1.Apagar();
                automovel2.Apagar();

                // Move the cars based on their speed and direction
                automovel1.Movimentar();
                automovel2.Movimentar();

                // Draw the cars in their new positions
                automovel1.Desenhar();
                automovel2.Desenhar();

                Thread.Sleep(200);  // Pause the loop for 200 milliseconds for smoother animation

                Console.Clear();  // Clears the console after the display to prevent flickering
            }
        }

        // Class representing a car (Automovel)
        public class Automovel
        {
            // Private fields for the car's position, direction, and odometer
            private int X;
            private int Y;
            private int direcao;  // Direction of movement (1 = forward, -1 = backward)

            // Public properties for odometer, speed, license plate, and color
            public int Quilometragem { get; private set; }  // Distance traveled by the car
            public int Velocidade { get; set; }  // Speed of the car
            public string Matricula { get; private set; }  // License plate of the car
            public ConsoleColor Cor { get; set; }  // Color of the car

            // Constructor for initializing the car's position, odometer, license plate, and color
            public Automovel(int x, int y, int quilometragem, string matricula, ConsoleColor cor)
            {
                X = x;
                Y = y;
                Quilometragem = quilometragem;
                Matricula = matricula;
                Cor = cor;
                direcao = 1;  // Initially moving forward
            }

            // Method to erase the car's previous position in the console
            public void Apagar()
            {
                Console.SetCursorPosition(X + 1, Y);  // Move to the previous position
                Console.Write(" ");  // Clear the character at that position
                Console.SetCursorPosition(X, Y + 1);
                Console.Write(" ");  // Clear the character in the line below
            }

            // Method to draw the car at its current position
            public void Desenhar()
            {
                // Save the current console background color
                ConsoleColor oldColor = Console.BackgroundColor;

                // Set the console background color to the car's color
                Console.BackgroundColor = Cor;

                // Draw the car (simple two-character wide representation)
                Console.SetCursorPosition(X, Y + 1);  // Draw the car's body
                Console.WriteLine(" ºº" );

                Console.SetCursorPosition(X + 1, Y);  // Draw the car's top (not visible, for padding)
                Console.WriteLine("   ");

                // Restore the original console background color
                Console.BackgroundColor = oldColor;
            }

            // Method to move the car
            public void Movimentar()
            {
                int windowWidth = Console.WindowWidth;  // Get the console window width

                // Update the car's position based on its speed and direction
                X += direcao * Velocidade;

                // Check if the car hits the left or right edge of the console window
                if (X < 0)
                {
                    X = 0;  // If it hits the left edge, stop it and change direction
                    direcao = 1;  // Change direction to forward
                }
                else if (X + 4 >= windowWidth)
                {
                    X = windowWidth - 4;  // If it hits the right edge, stop it and change direction
                    direcao = -1;  // Change direction to backward
                }

                // Increase the odometer based on the speed (accumulating distance traveled)
                Quilometragem += Velocidade;
            }
        }
    }
}


