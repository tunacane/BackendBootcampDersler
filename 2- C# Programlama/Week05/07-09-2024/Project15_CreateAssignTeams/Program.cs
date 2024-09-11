namespace Project15_CreateAssignTeams;

class Program
{
    static void Main(string[] args)
    {
        string[] students ={
            "Hakan Çakdı",
            "Tunacan Eşki",
            "Rojin Çetiz",
            "Elif ÖZtürk",
            "Ömer Taştekin",
            "Enes Kılıçaslan",
            "Atlas Uyar",
            "Erdem Yüce Gül",
            "Enes Can Aydemir",
            "Irmak Özen",
            "Burhan Torun",
            "Miraç Katmer",
            "Bedirhan Çaylı",
            "Melina Balcı",
            "Merve Kahraman",
            "Kerem Can Kırpar",
            "Gizem Yüksel",
            "Celal Uğur Koçan",
            "Tahir Burak Avar",
            "Samet Önür",
            "Aleyna Çelen",
            "Elifnur Binici",
            "Doğukan Babayiğit",
            "Emre Kılıç"
        } ;
        
        string[] teamName = {
            "Debuggers",
            "Codewars",
            "Algorithmics",
            "BinaryCoders",
            "NullPointers",
            "DevDynamics"
        };

        double memberCount = 4;
        int teamCount =(int) Math.Ceiling(students.Length /memberCount);

        string[] teams = new string[teamCount];
//    student dizisini karıştırma;
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);// 7
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex]=temp;
        }

        int teamCounter=0;
        string currentTeamName;
        for (int i = 0; i < students.Length; i+=4)
        {
            currentTeamName = teamName[teamCounter];
            System.Console.WriteLine($"Takımın Adı: {currentTeamName}");
            
            for (int j = 0; j < memberCount; j++)
            {
                System.Console.WriteLine($"\t\t-{students[i+j]}");
            }
            System.Console.WriteLine();
            teamCounter++;
        }
     
        
        
        
        
        
         }
}
// foreach (string s in students)
// {
//     System.Console.WriteLine(s);
// }