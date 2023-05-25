// Anthony Snyder
// IT112
// NOTES: I am so tired
// BEHAVIORS NOT IMPLIMENTED AND WHY: Did not have much time as i am at track state,
// but there is no excuses, i did not get this program to completely work.
namespace Snyder_RoboDialer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Phone[] dialingList = new Phone[10];
                dialingList[0] = new HomePhone("(303) 985-5060", "CompuTest");
                dialingList[1] = new CellPhone("(603) 532-4123", "Curtis Manufacturing");
                dialingList[2] = new HomePhone("(800) 876-2524", "Data Functions");
                dialingList[3] = new HomePhone("(708) 397-3330", "Donnay Repair");
                dialingList[4] = new HomePhone("(360) 434-3894", "ErgoNomic Inc");
                dialingList[5] = new HomePhone("(800) 969-4374", "ErgoSource");
                dialingList[6] = new CellPhone("(800) 874-8527", "Fox Bay Industries");
                dialingList[7] = new CellPhone("(800) 545-6254", "Glare-Guard");
                dialingList[8] = new CellPhone("(407) 783-6641", "Hazard Comm Specialists");
                dialingList[9] = new CellPhone("(714) 472-4409", "Komfort Support");

                foreach (Phone phone in dialingList)
                {
                    Console.WriteLine(phone.Dial());
                }
            }
        }
    }
}