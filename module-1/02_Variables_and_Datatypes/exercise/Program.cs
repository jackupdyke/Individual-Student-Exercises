namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */

            int raccoonsInWoods = 3;
            int raccoonsHomeToDinner = 2;
            int raccoonsRemaining = raccoonsInWoods - raccoonsHomeToDinner;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int flowers = 5;
            int bees = 3;
            int flowersLessBees = flowers - bees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int lonelyPigeon = 1;
            int newPigeon = 1;
            int totalPigeon = lonelyPigeon + newPigeon;

            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            int owls = 3;
            int newOwls = 2;
            int totalOwls = owls + newOwls;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int beavers = 2;
            int beaverLeft = 1;
            int totalBeaver = beavers - beaverLeft;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int toucans = 2;
            int newToucan = 1;
            int totalToucan = toucans + newToucan;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int squirrels = 4;
            int nuts = 2;
            int difference = squirrels - nuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            decimal quarter = 0.25M;
            decimal dime = 0.10M;
            decimal nickel = 0.05M;
            decimal totalMoney = quarter + dime + (2 * nickel);

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int brierMuffin = 18;
            int macadamsMuffin = 20;
            int flanneryMuffin = 17;
            int totalMuffin = brierMuffin + macadamsMuffin + flanneryMuffin;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            decimal yoyo = 0.24M;
            decimal whistle = 0.14M;
            decimal totalToys = yoyo + whistle;

            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */

            int riceKrispie = 5;
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;

            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int hiltHouse = 29;
            int brecknockHouse = 17;
            int hiltLessBrecknock = hiltHouse - brecknockHouse;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            decimal money = 10M;
            decimal truck = 3M;
            decimal pencil = 2M;
            decimal remaining = money - truck - pencil;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int marbles = 16;
            int lostMarbles = 7;
            int totalMarbles = marbles - lostMarbles;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int seashells = 19;
            int neededShells = 25;
            int shellsNeeded = neededShells - seashells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int redBalloons = 8;
            int totalBalloons = 17;
            int greenBalloons = totalBalloons - redBalloons;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int books = 38;
            int addedBooks = 10;
            int totalBooks = books + addedBooks;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int beeLegs = 6;
            int eightBeesLegCount = beeLegs * 8;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            decimal icecreamCost = 0.99M;
            decimal twoConeCost = 2 * icecreamCost;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int totalRockNeeded = 125;
            int rockOnHand = 64;
            int rockNeeded = totalRockNeeded - rockOnHand;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int totalMarble = 38;
            int lostMarble = 15;
            int remainingMarble = totalMarble - lostMarble;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int concertDistance = 78;
            int distanceCovered = 32;
            int distanceRemaining = concertDistance - distanceCovered;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */

            int morningMinutes = 90;
            int afternoonMinutes = 45;
            int totalMinutesShoveled = morningMinutes + afternoonMinutes;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            int hotDogCount = 6;
            decimal hotDogCost = 0.50M;
            decimal totalHotDogCost = hotDogCost * hotDogCount;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            decimal changeTotal = .50M;
            decimal pencilCost = .07M;
            decimal maxPencilPurchase = changeTotal / pencilCost;
            int maxPencilPossible = (int)maxPencilPurchase;

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int totalButterfly = 33;
            int orangeButterfly = 20;
            int redButterfly = totalButterfly - orangeButterfly;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            decimal moneyPaid = 1;
            decimal candyCost = 0.54M;
            decimal changeDue = moneyPaid - candyCost;



            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int currentTreeCount = 13;
            int newTree = 12;
            int totalTreeCount = currentTreeCount + newTree;

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int dayCount = 2;
            int hoursInDay = 24;
            int hoursRemaining = dayCount * hoursInDay;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int cousinCount = 4;
            int gumPerCousin = 5;
            int gumNeeded = cousinCount * gumPerCousin;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal moneyStart = 3.00M;
            decimal candybarCost = 1.00M;
            decimal moneyLeft = moneyStart - candybarCost;


            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int boatCount = 5;
            int peoplePerBoat = 3;
            int totalPeopleOnBoats = boatCount * peoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int legoCount = 380;
            int legoLost = 57;
            int legoRemaining = legoCount - legoLost;


            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int muffinCountNeeded = 83;
            int muffinBaked = 35;
            int muffinToBake = muffinCountNeeded - muffinBaked;


            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willyCrayonCount = 1400;
            int lucyCrayonCount = 290;
            int willyLessLucy = willyCrayonCount - lucyCrayonCount;



            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickerPerPage = 10;
            int pageCount = 22;
            int sticketTotal = stickerPerPage * pageCount;

            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            double cupcakeCount = 100.0;
            double childrenCount = 8.0;
            double cupcakePerChild = cupcakeCount / childrenCount;


            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */

            int gingerbreadTotal = 47;
            int cookiesPerJar = 6;
            int cookiesNotInJar = gingerbreadTotal % cookiesPerJar;


            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */

            int croissantCount = 59;
            int neighborCount = 8;
            int croissantRemaining = croissantCount % neighborCount;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int cookiePerTray = 12;
            int cookieTotal = 276;
            int trayCount = cookieTotal / cookiePerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int pretzelCount = 480;
            int servingSize = 12;
            int servingsOfPretzels = pretzelCount / servingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int lemonCupcakeCount = 53;
            int cupcakeLeftAtHome = 2;
            int cupcakesPerBox = 3;
            int boxesGiven = (lemonCupcakeCount - cupcakeLeftAtHome) / cupcakesPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int carrotStickCount = 74;
            int peopleCount = 12;
            int uneatenCarrot = carrotStickCount % peopleCount;


            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int teddybearCount = 98;
            int teddybearPerShelf = 7;
            int shelvesFilled = teddybearCount / teddybearPerShelf;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int picturesPerAlbum = 20;
            int pictureCount = 480;
            int albumCountNeeded = pictureCount / picturesPerAlbum;


            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int tradingCardCount = 94;
            int cardsPerBox = 8;
            int filledBoxes = tradingCardCount / cardsPerBox;
            int unfilledCardCount = tradingCardCount % cardsPerBox;


            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int bookCount = 210;
            int shelfCount = 10;
            int booksPerShelf = bookCount / shelfCount;


            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            double croissantTotal = 17.0;
            double guestCount = 7.0;
            double croissantPerGuest = croissantTotal / guestCount;

            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */

            int roomLength = 12;
            int roomWidth = 14;
            int roomCount = 5;
            int roomSizeInFeet = roomLength * roomWidth;
            double billTimeFootPerHour = roomSizeInFeet / 2.15;
            double jillTimeFootPerHour = roomSizeInFeet / 1.90;
            double combinedFootPerHour = billTimeFootPerHour + jillTimeFootPerHour;
            double timeTotal = (roomLength * roomWidth * roomCount) / combinedFootPerHour;



            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */

            string firstName = "Grace";
            string middleInitial = "B";
            string lastName = "Hopper";

            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";

            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */

            double distanceNewYorkToChicago = 800.0;
            double distanceTraveled = 537.0;
            double decimalComplemeted = (distanceTraveled / distanceNewYorkToChicago) * 100.0;
            int percentCompleted = (int)decimalComplemeted;
            
        }
    }
}
