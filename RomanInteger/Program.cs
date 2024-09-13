namespace RomanInteger {
    internal class Program {


        static void Main(string[] args) {

            #region SINGLETON
            //FileManager fileManager = new FileManager();

            FileManager.GetInstance().LoadFile("cat.txt");
            Console.WriteLine($"Files loaded :{FileManager.GetInstance().loadedSize}");

            FileManager.LoadFile2("cat.txt");

            AudioPlayer player = new AudioPlayer(FileManager.GetInstance());
            player.PlayMusic("cat.txt");
            // PlayMusic("fav.mp3");
            // PlaySound("MouseButton.wav");



            PaintHistory historyOwnedByThisFunction = new PaintHistory();

            PaintHistory history = PaintHistory.Shared();

            history.SaveAction(new Action { Name = "Brush" });
            history.SaveAction(new Action { Name = "Brush" });
            history.SaveAction(new Action { Name = "Open File" });
            history.SaveAction(new Action { Name = "Erased" });

            history.Rollback();
            history.Rollback();

            Boss boss = new Boss();
            boss.WinningBehavior();

            #endregion


            #region PROTOTYPE

            //Create prototype
            Food burger = new Food();
            burger.AddIngridient("kotleta");
            burger.AddIngridient("bulka");
            burger.AddIngridient("salat");
            burger.AddIngridient("cheese");

            // Create reference NOT COPY
            Food burder2 = burger;


            // DO FULL COPY
            Food burgerCopy = burger.Clone();
            burgerCopy.AddIngridient("Ketchup");

            Food burgerCopy2 = burger.Clone();
            burgerCopy2.AddIngridient("mayo");

            // WITHOUT PROTOTYPE
            Food burgerCopyWithoutPrototype = new Food();
            burgerCopyWithoutPrototype.AddIngridient("kotleta");
            burgerCopyWithoutPrototype.AddIngridient("bulka");
            burgerCopyWithoutPrototype.AddIngridient("salat");
            burgerCopyWithoutPrototype.AddIngridient("cheese");
            burgerCopyWithoutPrototype.AddIngridient("pickle");

            #endregion

            #region Factory Method

            Sport unknownSport = SportFactory.CreateSport(12);
            Console.WriteLine(unknownSport.Name());
            Console.WriteLine(unknownSport.GetRules());
            unknownSport.Practice();
            unknownSport.Play();

            Sport unknownSport2 = SportFactory.CreateSport(13);
            Console.WriteLine(unknownSport2.Name());
            Console.WriteLine(unknownSport2.GetRules());
            unknownSport2.Practice();
            unknownSport2.Play();


            #endregion


            #region Abstract Factory


            EnemyBoss enemyBoss = new EnemyBoss(new AggressiveEnemyAi(), new Sword());

            Hero hero = new Hero { HealthPoints = 100 };
            Console.WriteLine(enemyBoss.NextAction());
            enemyBoss.AttackHero(hero);
            Console.WriteLine(hero.HealthPoints);


            EnemyBoss enemyBoss2 = new EnemyBoss(new EasyBossDifficulty());
            EnemyBoss enemyBoss3 = new EnemyBoss(new MediumBossDifficulty());
            EnemyBoss enemyBoss4 = new EnemyBoss(new HardBossDifficulty());

            #endregion


            #region Builder

            Kitchen kitchen = KitchenBuilder.Builder()
                .AddFurniture(new Chair())
                .AddFurniture(new Table())
                .AddElectronicDevice(new Teapot())
                .AddElectronicDevice(new IceCamera())
                .Build();

            Furniture[] furnitures = new Furniture[3] {
                new Chair(), new Chair(), new Table()
            };
            ElectonicDevices[] devices = new ElectonicDevices[2] {
                new Teapot(), new IceCamera()
            };
            Kitchen kitchenSimple = new Kitchen(furnitures, devices);

            Kitchen kitchenAdvanced = KitchenBuilder.Builder()
                .AddChair(10)
                .AddTable()
                .AddTeaPot()
                .AddIceCamera()
                .Build();

            #endregion
        }
    }
}
