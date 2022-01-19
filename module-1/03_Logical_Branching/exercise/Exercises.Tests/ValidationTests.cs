using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Exercises.Tests
{
    [TestClass]
    public class ValidationTests
    {
        private readonly LogicalBranchingExercises exercises = new LogicalBranchingExercises();

        /*
	     SleepIn(false, false) → true
	     SleepIn(true, false) → false
	     SleepIn(false, true) → true
	     */
        [TestMethod]
        public void Exercise01_SleepIn()
        {
            Assert.AreEqual(true, exercises.SleepIn(false, false), "SleepIn(false, false)");
            Assert.AreEqual(false, exercises.SleepIn(true, false), "SleepIn(true, false)");
            Assert.AreEqual(true, exercises.SleepIn(false, true), "SleepIn(false, true)");
            Assert.AreEqual(true, exercises.SleepIn(true, true), "SleepIn(true, true)");
        }

        /*
         MonkeyTrouble(true, true) → true
         MonkeyTrouble(false, false) → true
         MonkeyTrouble(true, false) → false
         */
        [TestMethod]
        public void Exercise02_MonkeyTrouble()
        {
            Assert.AreEqual(true, exercises.MonkeyTrouble(true, true), "Input: MonkeyTrouble(true, true)");
            Assert.AreEqual(true, exercises.MonkeyTrouble(false, false), "Input: MonkeyTrouble(false, false)");
            Assert.AreEqual(false, exercises.MonkeyTrouble(true, false), "Input: MonkeyTrouble(true, false)");
            Assert.AreEqual(false, exercises.MonkeyTrouble(false, true), "Input: MonkeyTrouble(false, true)");
        }

        /*
         SumDouble(1, 2) → 3
         SumDouble(3, 2) → 5
         SumDouble(2, 2) → 8
         */
        [TestMethod]
        public void Exercise03_SumDouble()
        {
            Assert.AreEqual(3, exercises.SumDouble(1, 2), "Input: SumDouble(1, 2)");
            Assert.AreEqual(5, exercises.SumDouble(3, 2), "Input: SumDouble(3, 2)");
            Assert.AreEqual(8, exercises.SumDouble(2, 2), "Input: SumDouble(2, 2)");
            Assert.AreEqual(-1, exercises.SumDouble(-1, 0), "Input: SumDouble(-1, 2)");
            Assert.AreEqual(12, exercises.SumDouble(3, 3), "Input: SumDouble(3, 3)");
            Assert.AreEqual(0, exercises.SumDouble(0, 0), "Input: SumDouble(0, 0)");
            Assert.AreEqual(1, exercises.SumDouble(0, 1), "Input: SumDouble(0, 1)");
            Assert.AreEqual(7, exercises.SumDouble(3, 4), "Input: SumDouble(3, 4)");
        }

        /*
         Diff21(19) → 2
         Diff21(10) → 11
         Diff21(21) → 0
         */
        [TestMethod]
        public void Exercise04_Diff21()
        {
            Assert.AreEqual(2, exercises.Diff21(19), "Input: Diff21(19)");
            Assert.AreEqual(11, exercises.Diff21(10), "Input: Diff21(10)");
            Assert.AreEqual(0, exercises.Diff21(21), "Input: Diff21(21)");
            Assert.AreEqual(2, exercises.Diff21(22), "Input: Diff21(22)");
            Assert.AreEqual(8, exercises.Diff21(25), "Input: Diff21(25)");
            Assert.AreEqual(18, exercises.Diff21(30), "Input: Diff21(30)");
            Assert.AreEqual(21, exercises.Diff21(0), "Input: Diff21(0)");
            Assert.AreEqual(20, exercises.Diff21(1), "Input: Diff21(1)");
            Assert.AreEqual(19, exercises.Diff21(2), "Input: Diff21(2)");
            Assert.AreEqual(22, exercises.Diff21(-1), "Input: Diff21(-1)");
            Assert.AreEqual(23, exercises.Diff21(-2), "Input: Diff21(-2)");
            Assert.AreEqual(58, exercises.Diff21(50), "Input: Diff21(50)");
        }

        /*
         ParrotTrouble(true, 6) → true
         ParrotTrouble(true, 7) → false
         ParrotTrouble(false, 6) → false
         */
        [TestMethod]
        public void Exercise05_ParrotTrouble()
        {
            Assert.AreEqual(true, exercises.ParrotTrouble(true, 6), "Input: ParrotTrouble(true, 6)");
            Assert.AreEqual(false, exercises.ParrotTrouble(true, 7), "Input: ParrotTrouble(true, 7)");
            Assert.AreEqual(false, exercises.ParrotTrouble(false, 6), "Input: ParrotTrouble(false, 6)");
            Assert.AreEqual(true, exercises.ParrotTrouble(true, 21), "Input: ParrotTrouble(true, 21)");
            Assert.AreEqual(false, exercises.ParrotTrouble(false, 21), "Input: ParrotTrouble(false, 21)");
            Assert.AreEqual(false, exercises.ParrotTrouble(false, 20), "Input: ParrotTrouble(false, 20)");
            Assert.AreEqual(true, exercises.ParrotTrouble(true, 23), "Input: ParrotTrouble(true, 23)");
            Assert.AreEqual(false, exercises.ParrotTrouble(false, 23), "Input: ParrotTrouble(false, 23)");
            Assert.AreEqual(false, exercises.ParrotTrouble(true, 20), "Input: ParrotTrouble(true, 20)");
            Assert.AreEqual(false, exercises.ParrotTrouble(false, 12), "Input: ParrotTrouble(false, 12)");
        }

        /*
         Makes10(9, 10) → true
         Makes10(9, 9) → false
         Makes10(1, 9) → true
         */
        [TestMethod]
        public void Exercise06_Makes10()
        {
            Assert.AreEqual(true, exercises.Makes10(9, 10), "Input: Makes10(9, 10)");
            Assert.AreEqual(false, exercises.Makes10(9, 9), "Input: Makes10(9, 9)");
            Assert.AreEqual(true, exercises.Makes10(1, 9), "Input: Makes10(1, 9)");
            Assert.AreEqual(true, exercises.Makes10(10, 1), "Input: Makes10(10, 1)");
            Assert.AreEqual(true, exercises.Makes10(10, 10), "Input: Makes10(10, 10)");
            Assert.AreEqual(true, exercises.Makes10(8, 2), "Input: Makes10(8, 2)");
            Assert.AreEqual(false, exercises.Makes10(8, 3), "Input: Makes10(8, 3)");
            Assert.AreEqual(true, exercises.Makes10(10, 42), "Input: Makes10(10, 42)");
            Assert.AreEqual(true, exercises.Makes10(12, -2), "Input: Makes10(12, -2)");
        }

        /*
         PosNeg(1, -1, false) → true
         PosNeg(-1, 1, false) → true
         PosNeg(-4, -5, true) → true
         */
        [TestMethod]
        public void Exercise07_PosNeg()
        {
            Assert.AreEqual(true, exercises.PosNeg(1, -1, false), "Input: PosNeg(1, -1, false)");
            Assert.AreEqual(false, exercises.PosNeg(1, -1, true), "Input: PosNeg(1, -1, true)");
            Assert.AreEqual(true, exercises.PosNeg(-1, 1, false), "Input: PosNeg(-1, 1, false)");
            Assert.AreEqual(false, exercises.PosNeg(-1, 1, true), "Input: PosNeg(-1, 1, true)");
            Assert.AreEqual(true, exercises.PosNeg(-4, -5, true), "Input: PosNeg(-4, -5, true)");
            Assert.AreEqual(false, exercises.PosNeg(-4, -5, false), "Input: PosNeg(-4, -5, false)");
            Assert.AreEqual(false, exercises.PosNeg(9, 12, true), "Input: PosNeg(9, 12, true)");
            Assert.AreEqual(false, exercises.PosNeg(9, 12, false), "Input: PosNeg(9, 12, false)");
        }

        /*
         Or35(3) → true
         Or35(10) → true
         Or35(8) → false
         */
        [TestMethod]
        public void Exercise08_Or35()
        {
            Assert.AreEqual(true, exercises.Or35(3), "Input: Or35(3)");
            Assert.AreEqual(true, exercises.Or35(10), "Input: Or35(10)");
            Assert.AreEqual(false, exercises.Or35(8), "Input: Or35(8)");
            Assert.AreEqual(true, exercises.Or35(30), "Input: Or35(30)");
        }

        /*
         IcyHot(120, -1) → true
         IcyHot(-1, 120) → true
         IcyHot(2, 120) → false
         */
        [TestMethod]
        public void Exercise09_IcyHot()
        {
            Assert.AreEqual(true, exercises.IcyHot(120, -1), "Input: IcyHot(120, -1)");
            Assert.AreEqual(true, exercises.IcyHot(-1, 120), "Input: IcyHot(-1, 120)");
            Assert.AreEqual(false, exercises.IcyHot(2, 120), "Input: IcyHot(2, 120)");
            Assert.AreEqual(false, exercises.IcyHot(2, 99), "Input: IcyHot(2, 99)");
            Assert.AreEqual(false, exercises.IcyHot(-2, 99), "Input: IcyHot(-2, 99)");
            Assert.AreEqual(false, exercises.IcyHot(0, 100), "Input: IcyHot(0, 100)");
        }

        /*
         In1020(12, 99) → true
         In1020(21, 12) → true
         In1020(8, 99) → false
         */
        [TestMethod]
        public void Exercise10_In1020()
        {
            Assert.AreEqual(true, exercises.In1020(12, 99), "Input: In1020(12, 99)");
            Assert.AreEqual(true, exercises.In1020(21, 12), "Input: In1020(21, 12)");
            Assert.AreEqual(false, exercises.In1020(8, 99), "Input: In1020(8, 99)");
            Assert.AreEqual(true, exercises.In1020(11, 19), "Input: In1020(11, 19)");
        }

        /*
         HasTeen(13, 20, 10) → true
         HasTeen(20, 19, 10) → true
         HasTeen(20, 10, 13) → true
         */
        [TestMethod]

        public void Exercise11_HasTeen()
        {
            Assert.AreEqual(true, exercises.HasTeen(13, 20, 10), "Input: HasTeen(13, 20, 10)");
            Assert.AreEqual(true, exercises.HasTeen(20, 19, 10), "Input: HasTeen(20, 19, 10)");
            Assert.AreEqual(true, exercises.HasTeen(20, 10, 13), "Input: HasTeen(20, 10, 13)");
            Assert.AreEqual(true, exercises.HasTeen(13, 14, 10), "Input: HasTeen(13, 14, 10)");
            Assert.AreEqual(true, exercises.HasTeen(13, 10, 14), "Input: HasTeen(13, 10, 14)");
            Assert.AreEqual(true, exercises.HasTeen(10, 13, 19), "Input: HasTeen(10, 13, 19)");
            Assert.AreEqual(true, exercises.HasTeen(13, 14, 15), "Input: HasTeen(13, 14, 15)");
            Assert.AreEqual(false, exercises.HasTeen(1, 2, 3), "Input: HasTeen(1, 2, 3)");
            Assert.AreEqual(false, exercises.HasTeen(21, 22, 23), "Input: HasTeen(21, 22, 23)");
            Assert.AreEqual(false, exercises.HasTeen(1, 2, 23), "Input: HasTeen(1, 2, 23)");
        }

        /*
         LoneTeen(13, 99) → true
         LoneTeen(21, 19) → true
         LoneTeen(13, 13) → false
         */
        [TestMethod]

        public void Exercise12_LoneTeen()
        {
            Assert.AreEqual(true, exercises.LoneTeen(13, 99), "Input: LoneTeen(13, 99)");
            Assert.AreEqual(true, exercises.LoneTeen(21, 19), "Input: LoneTeen(21, 19)");
            Assert.AreEqual(false, exercises.LoneTeen(13, 13), "Input: LoneTeen(13, 13)");
            Assert.AreEqual(false, exercises.LoneTeen(12, 20), "Input: LoneTeen(12, 20)");
            Assert.AreEqual(false, exercises.LoneTeen(20, 12), "Input: LoneTeen(20, 12)");
            Assert.AreEqual(false, exercises.LoneTeen(12, 2), "Input: LoneTeen(12, 2)");
            Assert.AreEqual(false, exercises.LoneTeen(23, 20), "Input: LoneTeen(23, 20)");
        }

        /*
         IntMax(1, 2, 3) → 3
         IntMax(1, 3, 2) → 3
         IntMax(3, 2, 1) → 3
         */
        [TestMethod]
        public void Exercise13_IntMax()
        {
            Assert.AreEqual(3, exercises.IntMax(1, 2, 3), "Input: IntMax(1, 2, 3)");
            Assert.AreEqual(3, exercises.IntMax(1, 3, 2), "Input: IntMax(1, 3, 2)");
            Assert.AreEqual(3, exercises.IntMax(3, 2, 1), "Input: IntMax(3, 2, 1)");
            Assert.AreEqual(4, exercises.IntMax(4, 4, 1), "Input: IntMax(4, 4, 1)");
            Assert.AreEqual(5, exercises.IntMax(5, 2, 5), "Input: IntMax(5, 2, 5)");
            Assert.AreEqual(5, exercises.IntMax(3, 5, 5), "Input: IntMax(3, 5, 5)");
            Assert.AreEqual(9, exercises.IntMax(9, 1, 1), "Input: IntMax(9, 1, 1)");
            Assert.AreEqual(9, exercises.IntMax(9, 9, 9), "Input: IntMax(9, 9, 9)");
        }

        /*
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        [TestMethod]
        public void Exercise14_In3050()
        {
            Assert.AreEqual(true, exercises.In3050(30, 31), "Input: In3050(30, 31)");
            Assert.AreEqual(false, exercises.In3050(30, 41), "Input: In3050(30, 41)");
            Assert.AreEqual(true, exercises.In3050(40, 50), "Input: In3050(40, 50)");
            Assert.AreEqual(false, exercises.In3050(20, 21), "Input: In3050(20, 21)");
            Assert.AreEqual(false, exercises.In3050(30, 5), "Input: In3050(30, 5)");
            Assert.AreEqual(false, exercises.In3050(40, 75), "Input: In3050(40, 75)");
        }

        /*
         Max1020(11, 19) → 19
         Max1020(19, 11) → 19
         Max1020(11, 9) → 11
         */
        [TestMethod]
        public void Exercise15_Max1020()
        {
            Assert.AreEqual(19, exercises.Max1020(11, 19), "Input: Max1020(11, 19)");
            Assert.AreEqual(19, exercises.Max1020(19, 11), "Input: Max1020(19, 11)");
            Assert.AreEqual(11, exercises.Max1020(11, 9), "Input: Max1020(11, 9)");
            Assert.AreEqual(11, exercises.Max1020(11, 21), "Input: Max1020(11, 21)");
            Assert.AreEqual(0, exercises.Max1020(9, 21), "Input: Max1020(9, 21)");
            Assert.AreEqual(0, exercises.Max1020(1, 9), "Input: Max1020(1, 9)");
            Assert.AreEqual(0, exercises.Max1020(21, 100), "Input: Max1020(21, 100)");
        }

        /*
         CigarParty(30, false) → false
         CigarParty(50, false) → true
         CigarParty(70, true) → true
         */
        [TestMethod]
        public void Exercise16_CigarParty()
        {
            Assert.AreEqual(false, exercises.CigarParty(30, false), "Input: CigarParty(30, false)");
            Assert.AreEqual(true, exercises.CigarParty(50, false), "Input: CigarParty(50, false)");
            Assert.AreEqual(true, exercises.CigarParty(70, true), "Input: CigarParty(70, true)");
            Assert.AreEqual(false, exercises.CigarParty(70, false), "Input: CigarParty(70, false)");
            Assert.AreEqual(false, exercises.CigarParty(30, true), "Input: CigarParty(30, true)");
            Assert.AreEqual(true, exercises.CigarParty(40, true), "Input: CigarParty(40, true)");
            Assert.AreEqual(true, exercises.CigarParty(40, false), "Input: CigarParty(40, false)");
            Assert.AreEqual(true, exercises.CigarParty(60, false), "Input: CigarParty(60, false)");
        }

        /*
         DateFashion(5, 10) → 2
         DateFashion(5, 2) → 0
         DateFashion(5, 5) → 1
         */
        [TestMethod]
        public void Exercise17_DateFashion()
        {
            Assert.AreEqual(2, exercises.DateFashion(5, 10), "Input: DateFashion(5, 10)");
            Assert.AreEqual(2, exercises.DateFashion(10, 5), "Input: DateFashion(10, 5)");
            Assert.AreEqual(2, exercises.DateFashion(8, 8), "Input: DateFashion(8, 8)");
            Assert.AreEqual(0, exercises.DateFashion(2, 10), "Input: DateFashion(2, 10)");
            Assert.AreEqual(0, exercises.DateFashion(10, 1), "Input: DateFashion(10, 1)");
            Assert.AreEqual(0, exercises.DateFashion(5, 2), "Input: DateFashion(5, 2)");
            Assert.AreEqual(0, exercises.DateFashion(2, 2), "Input: DateFashion(2, 2)");
            Assert.AreEqual(1, exercises.DateFashion(5, 5), "Input: DateFashion(5, 5)");
        }

        /*
         SquirrelPlay(70, false) → true
         SquirrelPlay(95, false) → false
         SquirrelPlay(95, true) → true
         */
        [TestMethod]
        public void Exercise18_SquirrelPlay()
        {
            Assert.AreEqual(true, exercises.SquirrelPlay(70, false), "Input: SquirrelPlay(70, false)");
            Assert.AreEqual(false, exercises.SquirrelPlay(95, false), "Input: SquirrelPlay(95, false)");
            Assert.AreEqual(true, exercises.SquirrelPlay(95, true), "Input: SquirrelPlay(95, true)");
            Assert.AreEqual(true, exercises.SquirrelPlay(60, false), "Input: SquirrelPlay(60, false)");
            Assert.AreEqual(true, exercises.SquirrelPlay(90, false), "Input: SquirrelPlay(90, false)");
            Assert.AreEqual(true, exercises.SquirrelPlay(60, true), "Input: SquirrelPlay(60, true)");
            Assert.AreEqual(true, exercises.SquirrelPlay(90, true), "Input: SquirrelPlay(90, true)");
            Assert.AreEqual(true, exercises.SquirrelPlay(100, true), "Input: SquirrelPlay(100, true)");
            Assert.AreEqual(false, exercises.SquirrelPlay(101, true), "Input: SquirrelPlay(101, true)");
            Assert.AreEqual(false, exercises.SquirrelPlay(101, false), "Input: SquirrelPlay(101, false)");
        }

        /*
         YourCakeAndEatItToo(4.99, false) → "standard"
         YourCakeAndEatItToo(4.99, true) → "standard"
         YourCakeAndEatItToo(7.00, false) → "standard"
         YourCakeAndEatItToo(7.00, true) → "special"
         YourCakeAndEatItToo(10.00, false) → "standard"
         YourCakeAndEatItToo(10.00, true) → "special"
         YourCakeAndEatItToo(10.01, false) → "special"
         YourCakeAndEatItToo(10.01, true) → "ginormous"
         */
        [TestMethod]
        public void Exercise19_YourCakeAndEatItToo()
        {
            Assert.AreEqual("standard", exercises.YourCakeAndEatItToo(4.99, false), "Input: YourCakeAndEatItToo(4.99, false)");
            Assert.AreEqual("standard", exercises.YourCakeAndEatItToo(4.99, true), "Input: YourCakeAndEatItToo(4.99, true)");
            Assert.AreEqual("standard", exercises.YourCakeAndEatItToo(7.00, false), "Input: YourCakeAndEatItToo(7.00, false)");
            Assert.AreEqual("special", exercises.YourCakeAndEatItToo(7.00, true), "Input: YourCakeAndEatItToo(7.00, true)");
            Assert.AreEqual("standard", exercises.YourCakeAndEatItToo(10.00, false), "Input: YourCakeAndEatItToo(10.00, false)");
            Assert.AreEqual("special", exercises.YourCakeAndEatItToo(10.00, true), "Input: YourCakeAndEatItToo(10.00, true)");
            Assert.AreEqual("special", exercises.YourCakeAndEatItToo(10.01, false), "Input: YourCakeAndEatItToo(10.01, false)");
            Assert.AreEqual("ginormous", exercises.YourCakeAndEatItToo(10.01, true), "Input: YourCakeAndEatItToo(10.01, true)");
            Assert.AreEqual("special", exercises.YourCakeAndEatItToo(15.00, false), "Input: YourCakeAndEatItToo(15.00, false)");
            Assert.AreEqual("ginormous", exercises.YourCakeAndEatItToo(15.00, true), "Input: YourCakeAndEatItToo(15.00, true)");
            Assert.AreEqual("ginormous", exercises.YourCakeAndEatItToo(15.01, false), "Input: YourCakeAndEatItToo(15.01, false)");
            Assert.AreEqual("ginormous", exercises.YourCakeAndEatItToo(15.01, true), "Input: YourCakeAndEatItToo(15.01, true)");
        }

        /*
         SortaSum(3, 4) → 7
         SortaSum(9, 4) → 20
         SortaSum(10, 11) → 21
         */
        [TestMethod]
        public void Exercise20_SortaSum()
        {
            Assert.AreEqual(7, exercises.SortaSum(3, 4), "Input: SortaSum(3, 4)");
            Assert.AreEqual(20, exercises.SortaSum(9, 4), "Input: SortaSum(9, 4)");
            Assert.AreEqual(21, exercises.SortaSum(10, 11), "Input: SortaSum(10, 11)");
            Assert.AreEqual(20, exercises.SortaSum(6, 4), "Input: SortaSum(6, 4)");
            Assert.AreEqual(20, exercises.SortaSum(10, 9), "Input: SortaSum(10, 9)");
            Assert.AreEqual(20, exercises.SortaSum(10, 10), "Input: SortaSum(10, 10)");
            Assert.AreEqual(9, exercises.SortaSum(5, 4), "Input: SortaSum(5, 4)");
        }

        /*
         AlarmClock(1, false) → "7:00"
         AlarmClock(5, false) → "7:00"
         AlarmClock(0, false) → "10:00"
         */
        [TestMethod]
        public void Exercise21_AlarmClock()
        {
            Assert.AreEqual("7:00", exercises.AlarmClock(1, false), "Input: AlarmClock(1, false)");
            Assert.AreEqual("7:00", exercises.AlarmClock(5, false), "Input: AlarmClock(5, false)");
            Assert.AreEqual("10:00", exercises.AlarmClock(0, false), "Input: AlarmClock(0, false)");
            Assert.AreEqual("7:00", exercises.AlarmClock(2, false), "Input: AlarmClock(2, false)");
            Assert.AreEqual("7:00", exercises.AlarmClock(3, false), "Input: AlarmClock(3, false)");
            Assert.AreEqual("7:00", exercises.AlarmClock(4, false), "Input: AlarmClock(4, false)");
            Assert.AreEqual("7:00", exercises.AlarmClock(5, false), "Input: AlarmClock(5, false)");
            Assert.AreEqual("10:00", exercises.AlarmClock(6, false), "Input: AlarmClock(6, false)");
            Assert.AreEqual("10:00", exercises.AlarmClock(1, true), "Input: AlarmClock(1, true)");
            Assert.AreEqual("10:00", exercises.AlarmClock(2, true), "Input: AlarmClock(2, true)");
            Assert.AreEqual("10:00", exercises.AlarmClock(3, true), "Input: AlarmClock(3, true)");
            Assert.AreEqual("10:00", exercises.AlarmClock(4, true), "Input: AlarmClock(4, true)");
            Assert.AreEqual("10:00", exercises.AlarmClock(5, true), "Input: AlarmClock(5, true)");
            Assert.AreEqual("off", exercises.AlarmClock(0, true), "Input: AlarmClock(0, true)");
            Assert.AreEqual("off", exercises.AlarmClock(6, true), "Input: AlarmClock(6, true)");
        }

        /*
         In1To10(5, false) → true
         In1To10(11, false) → false
         In1To10(11, true) → true
         */
        [TestMethod]
        public void Exercise22_In1To10()
        {
            Assert.AreEqual(true, exercises.In1To10(5, false), "Input: In1To10(5, false)");
            Assert.AreEqual(false, exercises.In1To10(11, false), "Input: In1To10(11, false)");
            Assert.AreEqual(true, exercises.In1To10(11, true), "Input: In1To10(11, true)");
            Assert.AreEqual(true, exercises.In1To10(1, false), "Input: In1To10(1, false)");
            Assert.AreEqual(true, exercises.In1To10(10, false), "Input: In1To10(10, false)");
            Assert.AreEqual(false, exercises.In1To10(-1, false), "Input: In1To10(-1, false)");
            Assert.AreEqual(false, exercises.In1To10(0, false), "Input: In1To10(0, false)");
            Assert.AreEqual(false, exercises.In1To10(11, false), "Input: In1To10(11, false)");
            Assert.AreEqual(true, exercises.In1To10(1, true), "Input: In1To10(1, true)");
            Assert.AreEqual(true, exercises.In1To10(10, true), "Input: In1To10(10, true)");
            Assert.AreEqual(true, exercises.In1To10(-1, true), "Input: In1To10(-1, true)");
            Assert.AreEqual(true, exercises.In1To10(0, true), "Input: In1To10(0, true)");
            Assert.AreEqual(false, exercises.In1To10(5, true), "Input: In1To10(5, true)");
        }

        /*
         SpecialEleven(22) → true
         SpecialEleven(23) → true
         SpecialEleven(24) → false
         */
        [TestMethod]
        public void Exercise23_SpecialEleven()
        {
            Assert.AreEqual(true, exercises.SpecialEleven(22), "Input: SpecialEleven(22)");
            Assert.AreEqual(true, exercises.SpecialEleven(23), "Input: SpecialEleven(23)");
            Assert.AreEqual(false, exercises.SpecialEleven(24), "Input: SpecialEleven(24)");
            Assert.AreEqual(true, exercises.SpecialEleven(11), "Input: SpecialEleven(11)");
            Assert.AreEqual(true, exercises.SpecialEleven(12), "Input: SpecialEleven(12)");
            Assert.AreEqual(false, exercises.SpecialEleven(13), "Input: SpecialEleven(13)");
            Assert.AreEqual(false, exercises.SpecialEleven(10), "Input: SpecialEleven(10)");
        }

        /*
         More20(20) → false
         More20(21) → true
         More20(22) → true
         */
        [TestMethod]
        public void Exercise24_More20()
        {
            Assert.AreEqual(false, exercises.More20(20), "Input: More20(20)");
            Assert.AreEqual(true, exercises.More20(21), "Input: More20(21)");
            Assert.AreEqual(true, exercises.More20(22), "Input: More20(22)");
            Assert.AreEqual(false, exercises.More20(0), "Input: More20(0)");
            Assert.AreEqual(true, exercises.More20(1), "Input: More20(1)");
            Assert.AreEqual(true, exercises.More20(2), "Input: More20(2)");
            Assert.AreEqual(false, exercises.More20(40), "Input: More20(40)");
            Assert.AreEqual(true, exercises.More20(41), "Input: More20(41)");
            Assert.AreEqual(true, exercises.More20(42), "Input: More20(42)");
        }

        /*
         Old35(3) → true
         Old35(10) → true
         Old35(15) → false
         */
        [TestMethod]
        public void Exercise25_Old35()
        {
            Assert.AreEqual(true, exercises.Old35(3), "Input: Old35(3)");
            Assert.AreEqual(true, exercises.Old35(10), "Input: Old35(10)");
            Assert.AreEqual(false, exercises.Old35(15), "Input: Old35(15)");
            Assert.AreEqual(false, exercises.Old35(13), "Input: Old35(13)");
        }

        /*
         Less20(18) → true
         Less20(19) → true
         Less20(20) → false
         */
        [TestMethod]
        public void Exercise26_Less20()
        {
            Assert.AreEqual(true, exercises.Less20(18), "Input: Less20(18)");
            Assert.AreEqual(true, exercises.Less20(19), "Input: Less20(19)");
            Assert.AreEqual(false, exercises.Less20(20), "Input: Less20(20)");
            Assert.AreEqual(true, exercises.Less20(38), "Input: Less20(38)");
            Assert.AreEqual(true, exercises.Less20(39), "Input: Less20(39)");
            Assert.AreEqual(false, exercises.Less20(40), "Input: Less20(40)");
            Assert.AreEqual(false, exercises.Less20(21), "Input: Less20(21)");
            Assert.AreEqual(false, exercises.Less20(41), "Input: Less20(41)");
        }

        /*
         NearTen(12) → true
         NearTen(17) → false
         NearTen(19) → true
         */
        [TestMethod]
        public void Exercise27_NearTen()
        {
            Assert.AreEqual(true, exercises.NearTen(12), "Input: NearTen(12)");
            Assert.AreEqual(false, exercises.NearTen(17), "Input: NearTen(17)");
            Assert.AreEqual(true, exercises.NearTen(19), "Input: NearTen(19)");
            Assert.AreEqual(true, exercises.NearTen(10), "Input: NearTen(10)");
            Assert.AreEqual(true, exercises.NearTen(20), "Input: NearTen(20)");
            Assert.AreEqual(true, exercises.NearTen(8), "Input: NearTen(8)");
            Assert.AreEqual(true, exercises.NearTen(19), "Input: NearTen(19)");
            Assert.AreEqual(true, exercises.NearTen(21), "Input: NearTen(21)");
            Assert.AreEqual(false, exercises.NearTen(23), "Input: NearTen(23)");
        }

        /*
         TeenSum(3, 4) → 7
         TeenSum(10, 13) → 19
         TeenSum(13, 2) → 19
         */
        [TestMethod]
        public void Exercise28_TeenSum()
        {
            Assert.AreEqual(7, exercises.TeenSum(3, 4), "Input: TeenSum(3, 4)");
            Assert.AreEqual(19, exercises.TeenSum(10, 13), "Input: TeenSum(10, 13)");
            Assert.AreEqual(19, exercises.TeenSum(13, 2), "Input: TeenSum(13, 2)");
            Assert.AreEqual(19, exercises.TeenSum(15, 15), "Input: TeenSum(15, 15)");
            Assert.AreEqual(32, exercises.TeenSum(12, 20), "Input: TeenSum(12, 20)");
            Assert.AreEqual(43, exercises.TeenSum(21, 22), "Input: TeenSum(21, 22)");
        }

        /*
         AnswerCell(false, false, false) → true
         AnswerCell(false, false, true) → false
         AnswerCell(true, false, false) → false
         */
        [TestMethod]
        public void Exercise29_AnswerCell()
        {
            Assert.AreEqual(true, exercises.AnswerCell(false, false, false), "Input: AnswerCell(false, false, false)");
            Assert.AreEqual(false, exercises.AnswerCell(false, false, true), "Input: AnswerCell(false, false, true)");
            Assert.AreEqual(false, exercises.AnswerCell(true, false, false), "Input: AnswerCell(true, false, false)");
            Assert.AreEqual(true, exercises.AnswerCell(false, true, false), "Input: AnswerCell(false, true, false)");
            Assert.AreEqual(false, exercises.AnswerCell(false, true, true), "Input: AnswerCell(false, true, true)");
            Assert.AreEqual(false, exercises.AnswerCell(true, false, true), "Input: AnswerCell(true, false, true)");
            Assert.AreEqual(true, exercises.AnswerCell(true, true, false), "Input: AnswerCell(true, true, false)");
            Assert.AreEqual(false, exercises.AnswerCell(true, true, true), "Input: AnswerCell(true, true, true)");
        }

        /*
         TeaParty(6, 8) → 1
         TeaParty(3, 8) → 0
         TeaParty(20, 6) → 2
         */
        [TestMethod]
        public void Exercise30_TeaParty()
        {
            Assert.AreEqual(1, exercises.TeaParty(6, 8), "Input: TeaParty(6, 8)");
            Assert.AreEqual(0, exercises.TeaParty(3, 8), "Input: TeaParty(3, 8)");
            Assert.AreEqual(2, exercises.TeaParty(20, 6), "Input: TeaParty(20, 6)");
            Assert.AreEqual(1, exercises.TeaParty(5, 5), "Input: TeaParty(5, 5)");
            Assert.AreEqual(2, exercises.TeaParty(5, 10), "Input: TeaParty(5, 10)");
            Assert.AreEqual(2, exercises.TeaParty(10, 5), "Input: TeaParty(10, 5)");
            Assert.AreEqual(1, exercises.TeaParty(20, 25), "Input: TeaParty(20, 25)");
            Assert.AreEqual(0, exercises.TeaParty(4, 5), "Input: TeaParty(4, 5)");
            Assert.AreEqual(0, exercises.TeaParty(5, 4), "Input: TeaParty(5, 4)");
        }

        /*
         TwoAsOne(1, 2, 3) → true
         TwoAsOne(3, 1, 2) → true
         TwoAsOne(3, 2, 2) → false
         */
        [TestMethod]
        public void Exercise31_TwoAsOne()
        {
            Assert.AreEqual(true, exercises.TwoAsOne(1, 2, 3), "Input: TwoAsOne(1, 2, 3)");
            Assert.AreEqual(true, exercises.TwoAsOne(3, 1, 2), "Input: TwoAsOne(3, 1, 2)");
            Assert.AreEqual(false, exercises.TwoAsOne(3, 2, 2), "Input: TwoAsOne(3, 2, 2)");
            Assert.AreEqual(true, exercises.TwoAsOne(3, 2, 1), "Input: TwoAsOne(3, 2, 1)");
            Assert.AreEqual(true, exercises.TwoAsOne(2, 3, 1), "Input: TwoAsOne(2, 3, 1)");
        }

        /*
         InOrder(1, 2, 4, false) → true
         InOrder(1, 2, 1, false) → false
         InOrder(1, 1, 2, true) → true
         */
        [TestMethod]
        public void Exercise32_InOrder()
        {
            Assert.AreEqual(true, exercises.InOrder(1, 2, 4, false), "Input: InOrder(1, 2, 4, false)");
            Assert.AreEqual(false, exercises.InOrder(1, 2, 1, false), "Input: InOrder(1, 2, 1, false)");
            Assert.AreEqual(true, exercises.InOrder(1, 1, 2, true), "Input: InOrder(1, 1, 2, true)");
            Assert.AreEqual(false, exercises.InOrder(4, 2, 3, false), "Input: InOrder(4, 2, 3, false)");
            Assert.AreEqual(false, exercises.InOrder(1, 1, 2, false), "Input: InOrder(1, 1, 2, false)");
            Assert.AreEqual(false, exercises.InOrder(1, 2, 2, false), "Input: InOrder(1, 2, 2, false)");
            Assert.AreEqual(true, exercises.InOrder(5, 1, 2, true), "Input: InOrder(5, 1, 2, true)");
            Assert.AreEqual(false, exercises.InOrder(5, 1, 1, true), "Input: InOrder(5, 1, 1, true)");
        }

        /*
         InOrderEqual(2, 5, 11, false) → true
         InOrderEqual(5, 7, 6, false) → false
         InOrderEqual(5, 5, 7, true) → true
         */
        [TestMethod]
        public void Exercise33_InOrderEqual()
        {
            Assert.AreEqual(true, exercises.InOrderEqual(2, 5, 11, false), "Input: InOrderEqual(2, 5, 11, false)");
            Assert.AreEqual(false, exercises.InOrderEqual(5, 7, 6, false), "Input: InOrderEqual(5, 7, 6, false)");
            Assert.AreEqual(true, exercises.InOrderEqual(5, 5, 7, true), "Input: InOrderEqual(5, 5, 7, true)");
            Assert.AreEqual(false, exercises.InOrderEqual(5, 7, 6, true), "Input: InOrderEqual(5, 7, 6, true)");
            Assert.AreEqual(true, exercises.InOrderEqual(5, 5, 5, true), "Input: InOrderEqual(5, 5, 5, true)");
            Assert.AreEqual(true, exercises.InOrderEqual(1, 5, 5, true), "Input: InOrderEqual(1, 5, 5, true)");
            Assert.AreEqual(false, exercises.InOrderEqual(6, 5, 5, true), "Input: InOrderEqual(6, 5, 5, true)");
        }

        /*
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        [TestMethod]
        public void Exercise34_LoneSum()
        {
            Assert.AreEqual(6, exercises.LoneSum(1, 2, 3), "Input: LoneSum(1, 2, 3)");
            Assert.AreEqual(2, exercises.LoneSum(3, 2, 3), "Input: LoneSum(3, 2, 3)");
            Assert.AreEqual(0, exercises.LoneSum(3, 3, 3), "Input: LoneSum(3, 3, 3)");
            Assert.AreEqual(0, exercises.LoneSum(0, 1, 1), "Input: LoneSum(0, 1, 1)");
            Assert.AreEqual(3, exercises.LoneSum(3, 1, 1), "Input: LoneSum(3, 1, 1)");
            Assert.AreEqual(5, exercises.LoneSum(1, 1, 5), "Input: LoneSum(1, 1, 5)");
        }

        /*
         LuckySum(1, 2, 3) → 6
         LuckySum(1, 2, 13) → 3
         LuckySum(1, 13, 3) → 1
         LuckySum(13, 1, 3) → 3
         LuckySum(13, 13, 3) → 0
         */
        [DataTestMethod]
        public void Exercise35_LuckySum()
        {
            Assert.AreEqual(6, exercises.LuckySum(1, 2, 3), "Input: LuckySum(1, 2, 3)");
            Assert.AreEqual(3, exercises.LuckySum(1, 2, 13), "Input: LuckySum(1, 2, 13)");
            Assert.AreEqual(1, exercises.LuckySum(1, 13, 3), "Input: LuckySum(1, 13, 3)");
            Assert.AreEqual(3, exercises.LuckySum(13, 1, 3), "Input: LuckySum(13, 1, 3)");
            Assert.AreEqual(0, exercises.LuckySum(13, 13, 3), "Input: LuckySum(13, 13, 3)");
            Assert.AreEqual(0, exercises.LuckySum(13, 13, 13), "Input: LuckySum(13, 13, 13)");
        }
    }
}
