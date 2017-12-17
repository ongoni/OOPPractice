using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.IO;
using OOPPractice.CountingRhyme;
using OOPPractice.Patterns.AbstractFactory;
using OOPPractice.Patterns.AbstractFactory.Factories;
using OOPPractice.Patterns.Adapter;
using OOPPractice.Patterns.Adapter.AdaptedTransport;
using OOPPractice.Patterns.Adapter.Animal;
using OOPPractice.Patterns.Adapter.Transport;
using OOPPractice.Patterns.Builder;
using OOPPractice.Patterns.Builder.Builder;
using OOPPractice.Patterns.Builder.MagicStaff;
using OOPPractice.Patterns.Decorator.Decorators;
using OOPPractice.Patterns.Decorator.Weapons;
using OOPPractice.Patterns.Facade.Specialists.Government;
using OOPPractice.Patterns.Flyweight.Classes;
using OOPPractice.Patterns.Singleton;
using OOPPractice.Patterns.Strategy.Squads;
using OOPPractice.Patterns.Strategy.Strategies;

namespace OOPPractice.Patterns {

    public class Tasks {

        public static void countingRhyme() {
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            LoopedDoubleLinkedList list = new LoopedDoubleLinkedList();
            using (StreamReader sr = new StreamReader("../../input.txt")) {
                foreach (string item in sr.ReadToEnd().Split(' ')) {
                    list.Add(item);
                }
            }

            list.Show();
            int counter = 1;
            foreach (var item in list) {
                if (counter == k) {
                    list.Remove((string)item);
                    counter = 0;
                }
                counter++;
                
                if (list.Count == 1) break;
            }
            
            Console.WriteLine();
            list.Show();
        }
        
        public static void abstractFactory() {
            Hero mage = new Hero(new MageFactory());
            Hero rogue = new Hero(new RogueFactory());
            
            mage.Move();
            mage.Hit();
            
            rogue.Move();
            rogue.Hit();
        }

        public static void adapter() {
            Traveler traveler = new Traveler();
            HorseAndCart horseAndCart = new HorseAndCart();
            traveler.Travel(horseAndCart);
            
            Horse horse = new Horse();
            Transport horseTransport = new HorseTransportAdapter(horse);
            traveler.Travel(horseTransport);
        }

        public static void builder() {
            Mage mage = new Mage();
            
            MagicStaff fireMagicStaff = mage.CreateMagicStaff(new FireMagicStaffBuilder());
            MagicStaff drakonidMagicStaff = mage.CreateMagicStaff(new DrakonidMagicStaffBuilder());
            
            Console.WriteLine(fireMagicStaff);
            Console.WriteLine(drakonidMagicStaff);
        }

        public static void decorator() {
            MeleeWeapon sword = new Sword();
            Console.WriteLine(sword);
            sword = new EnchantedMeleeWeapon(sword);
            Console.WriteLine(sword);
            sword = new SharpenedMeleeWeapon(sword);
            Console.WriteLine(sword);
            
            MeleeWeapon dagger = new Dagger();
            Console.WriteLine(dagger);
            dagger = new EnchantedMeleeWeapon(dagger);
            Console.WriteLine(dagger);
            dagger = new OiledMeleeWeapon(dagger);
            Console.WriteLine(dagger);
            dagger = new SharpenedMeleeWeapon(dagger);
            Console.WriteLine(dagger);
        }

        public static void facade() {
            King king = new King("Kojima I");
            king.OrderToStartCrusade();
            king.OrderToStopCrusade();
        }

        public static void flyWeight() {
            Coffers coffers = new Coffers();
            for (int i = 0; i < 100; i++) {
                coffers.Replenish("Gold", 5);
                coffers.Replenish("Silver", 10);
                coffers.Replenish("Copper", 15);
            }
            
            coffers.Show();
        }

        public static void singleton() {
            Tantumwald tantumwald = Tantumwald.GetInstance();
            Console.WriteLine(tantumwald);
            tantumwald.CurrentKing = new King("Jonson I");
            Console.WriteLine(tantumwald);
        }

        public static void strategy() {
            AdventureSquad squad = new AdventureSquad();
            
            Strategy.Strategies.Strategy attack = new AttackingStrategy();
            Strategy.Strategies.Strategy defense = new DefensiveStrategy();
            Strategy.Strategies.Strategy retreat = new RetreatStrategy();
            
            squad.Apply(attack);
            squad.Apply(defense);
            squad.Apply(retreat);
        }
        
    }

}