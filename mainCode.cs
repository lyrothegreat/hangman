#pragma warning disable CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
#pragma warning disable CS8604
using System;
using System.Media;



//namespace CSharpTest;
namespace CSharpTest;

class mainCode{
    static string randomWord(){
        Random rnd=new Random();

        string[] wordList={"ability","able","about","above","accept","according","account","across","act","action","activity","actually","add","address","administration","admit","adult","affect","after","again","against","age","agency","agent","ago","agree","agreement","ahead","air","all","allow","almost","alone","along","already","also","although","always","American","among","amount","analysis","and","animal","another","answer","any","anyone","anything","appear","apply","approach","area","argue","arm","around","arrive","art","article","artist","as","ask","assume","at","attack","attention","attorney","audience","author","authority","available","avoid","away","baby","back","bad","bag","ball","bank","bar","base","be","beat","beautiful","because","become","bed","before","begin","behavior","behind","believe","benefit","best","better","between","beyond","big","bill","billion","bit","black","blood","blue","board","body","book","born","both","box","boy","break","bring","brother","budget","build","building","business","but","buy","by","call","camera","campaign","can","cancer","candidate","capital","car","card","care","career","carry","case","catch","cause","cell","center","central","century","certain","certainly","chair","challenge","chance","change","character","charge","check","child","choice","choose","church","citizen","city","civil","claim","class","clear","clearly","close","coach","cold","collection","college","color","come","commercial","common","community","company","compare","computer","concern","condition","conference","Congress","consider","consumer","contain","continue","control","cost","could","country","couple","course","court","cover","create","crime","cultural","culture","cup","current","customer","cut","dark","data","daughter","day","dead","deal","death","debate","decade","decide","decision","deep","defense","degree","Democrat","democratic","describe","design","despite","detail","determine","develop","development","die","difference","different","difficult","dinner","direction","director","discover","discuss","discussion","disease","do","doctor","dog","door","down","draw","dream","drive","drop","drug","during","each","early","east","easy","eat","economic","economy","edge","education","effect","effort","eight","either","election","else","employee","end","energy","enjoy","enough","enter","entire","environment","environmental","especially","establish","even","evening","event","ever","every","everybody","everyone","everything","evidence","exactly","example","executive","exist","expect","experience","expert","explain","eye","face","fact","factor","fail","fall","family","far","fast","father","fear","federal","feel","feeling","few","field","fight","figure","fill","film","final","finally","financial","find","fine","finger","finish","fire","firm","first","fish","five","floor","fly","focus","follow","food","foot","for","force","foreign","forget","form","former","forward","four","free","friend","from","front","full","fund","future","game","garden","gas","general","generation","get","girl","give","glass","go","goal","good","government","great","green","ground","group","grow","growth","guess","gun","guy","hair","half","hand","hang","happen","happy","hard","have","he","head","health","hear","heart","heat","heavy","help","her","here","herself","high","him","himself","his","history","hit","hold","home","hope","hospital","hot","hotel","hour","house","how","however","huge","human","hundred","husband","I","idea","identify","if","image","imagine","impact","important","improve","in","include","including","increase","indeed","indicate","individual","industry","information","inside","instead","institution","interest","interesting","international","interview","into","investment","involve","issue","it","item","its","itself","job","join","just","keep","key","kid","kill","kind","kitchen","know","knowledge","land","language","large","last","late","later","laugh","law","lawyer","lay","lead","leader","learn","least","leave","left","leg","legal","less","let","letter","level","lie","life","light","like","likely","line","list","listen","little","live","local","long","look","lose","loss","lot","love","low","machine","magazine","main","maintain","major","majority","make","man","manage","management","manager","many","market","marriage","material","matter","may","maybe","me","mean","measure","media","medical","meet","meeting","member","memory","mention","message","method","middle","might","military","million","mind","minute","miss","mission","model","modern","moment","money","month","more","morning","most","mother","mouth","move","movement","movie","Mr","Mrs","much","music","must","my","myself","name","nation","national","natural","nature","near","nearly","necessary","need","network","never","new","news","newspaper","next","nice","night","no","none","nor","north","not","note","nothing","notice","now","not","number","occur","of","off","offer","office","officer","official","often","oh","oil","ok","old","on","once","one","only","onto","open","operation","opportunity","option","or","order","organization","other","others","our","out","outside","over","own","owner","page","pain","painting","paper","parent","part","participant","particular","particularly","partner","party","pass","past","patient","pattern","pay","peace","people","per","perform","performance","perhaps","period","person","personal","phone","physical","pick","picture","piece","place","plan","plant","play","player","PM","point","police","policy","political","politics","poor","popular","population","position","positive","possible","power","practice","prepare","present","president","pressure","pretty","prevent","price","}private","probably","problem","process","produce","product","production","professional","professor","program","project","property","protect","prove","provide","public","pull","purpose","push","put","quality","question","quickly","quite","race","radio","raise","range","rate","rather","reach","read","ready","real","reality","realize","really","reason","receive","recent","recently","recognize","record","red","reduce","reflect","region","relate","relationship","religious","remain","remember","remove","report","represent","Republican","require","research","resource","respond","response","responsibility","rest","result","return","reveal","rich","right","rise","risk","road","rock","role","room","rule","run","safe","same","save","say","scene","school","science","scientist","score","sea","season","seat","second","section","security","see","seek","seem","sell","send","senior","sense","series","serious","serve","service","set","seven","several","sex","sexual","shake","share","she","shoot","short","shot","should","shoulder","show","side","sign","significant","similar","simple","simply","since","sing","single","sister","sit","site","situation","six","size","skill","skin","small","smile","so","social","society","soldier","some","somebody","someone","something","sometimes","son","song","soon","sort","sound","source","south","southern","space","speak","special","specific","speech","spend","sport","spring","staff","stage","stand","standard","star","start","state","statement","station","stay","step","still","stock","stop","store","story","strategy","street","strong","structure","student","study","stuff","style","subject","success","successful","such","suddenly","suffer","suggest","summer","support","sure","surface","system","table","take","talk","task","tax","teach","teacher","team","technology","television","tell","ten","tend","term","test","than","thank","that","the","their","them","themselves","then","theory","there","these","they","thing","think","third","this","those","though","thought","thousand","threat","three","through","throughout","throw","thus","time","to","today","together","tonight","too","top","total","tough","toward","town","trade","traditional","training","travel","treat","treatment","tree","trial","trip","trouble","true","truth","try","turn","TV","two","type","under","understand","unit","until","up","upon","us","use","usually","value","various","very","victim","view","violence","visit","voice","vote","wait","walk","wall","want","war","watch","water","way","we","weapon","wear","week","weight","well","west","western","what","whatever","when","where","whether","which","while","white","who","whole","whom","whose","why","wide","wife","will","win","wind","window","wish","with","within","without","woman","wonder","word","work","worker","world","worry","would","write","writer","wrong","yard","yeah","year","yes","yet","you","young","your","yourself"};
        
        int wordIndex=rnd.Next(0,wordList.Length);
        string word=wordList[wordIndex];
        return word;
    }
    static int[] Arraycheck(string answer,string usrGuess){
        List<Int32>positions=new List<Int32>();
            
        positions.Add(-1);
        for(int i=0;i<answer.Length;i++)
        {
            if(System.Convert.ToChar(usrGuess)==System.Convert.ToChar(answer[i]))
            {
                if(positions[0]==-1)
                {
                    positions[0]=i;
                }
                else
                {
                    positions.Add(i);
                }
            }   

        }

        int[]positionsArray=positions.ToArray();
        return positionsArray;

}
    static void drawKeyboard(string[] WrongAnswers, string[] UserInputs, string[] keyboard)
    {
    
        for (int i = 0; i < keyboard.Length; i++)
        {
            if (i == 10)
            {
                Console.WriteLine("");
                Console.Write("  ");
            }
    
            if (i == 19)
            {
                Console.WriteLine("");
                Console.Write("    ");
            }
    
            if (WrongAnswers.Contains(keyboard[i]))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(keyboard[i]);
                Console.ResetColor();
            }
            else if (UserInputs.Contains(keyboard[i]))
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(keyboard[i]);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(keyboard[i]);
                Console.ResetColor();
            }
    
            Console.Write("  ");
            
        }
        Console.WriteLine("");
    }

    static void giveHint(string answer, string[] UserInputs, string[] userResult)
    {
        Random rnd=new Random();
        string[] tempInputs = [];
        string[] tempResults = [];
        for (int i = 0; i < UserInputs.Length; i++)
        {
            if (answer.Contains(UserInputs[i]))
            {
                tempInputs.Append(UserInputs[i]);
            }
        }

        for (int i = 0; i < tempInputs.Length; i++)
        {
            if (answer.Contains(tempInputs[i]) == false)
            {
                tempResults[i] = tempInputs[i];
            }
        }
        int charIndex = rnd.Next(0,tempResults.Length);
        string hint = tempResults[charIndex];
        
    }
    static bool CheckIfDead(int NumOfWrongs){
        if(NumOfWrongs==9){
            return true;
        }
        return false;
    }
    static bool CheckIfWin (string answer,string userCurrent){
        if(answer.Equals(userCurrent)){
            return true;
        }
        return false;
    }
    static bool IsInArray(string[] strings,string target){
        foreach(string str in strings){
            if(str==target){
                return true;
            }
        }
        return false;
    }
    public static void PlayMusic(string filepath)
    {
        SoundPlayer musicPlayer = new SoundPlayer();
        musicPlayer.SoundLocation = filepath;
        musicPlayer.Play();
    }
    static void losingScreen(string correctWord){
        
        PlayMusic("clown.wav");
        
        Console.WriteLine("oh...");
        Thread.Sleep(2000);
        Console.WriteLine("you poor thing...");
        Thread.Sleep(2000);
        Console.WriteLine("the word was '"+correctWord+"' silly!");
        Thread.Sleep(2000);
        Console.WriteLine("what a shame.");
        Thread.Sleep(2000);
        Console.WriteLine("hah..");
        Thread.Sleep(1200);
        Console.WriteLine("hahahah....");
        Thread.Sleep(1200);
        Console.WriteLine("HAHAHAH........");
        Thread.Sleep(1300);
        
        Type type = typeof(ConsoleColor);
        
        int a=1;

        while (a==1){
            for(int i=0;i<15;i++){
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            foreach (var name in Enum.GetNames(type)){
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.Write("HA");
            }
        }
    }
    static void Main(string[] args)
        
    {
        
        string[] keyboard = ["q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m"];
        string []hangman=new string [10];
        hangman[9]="\n--------------------\n|\t\t|\n|\t\t0\n|\t       /|\\ \n|\t       / \\\n";
        hangman[8]="\n--------------------\n|\t\t|\n|\t\t0\n|\t       /|\\   \n|\t       / \n";
        hangman[7]="\n--------------------\n|\t\t|\n|\t\t0\n|\t       /|\\   \n|\t         \n";
        hangman[6]="\n--------------------\n|\t\t|\n|\t\t0\n|\t       /|     \n|\t         \n";
        hangman[5]="\n--------------------\n|\t\t|\n|\t\t0\n|\t       /      \n|\t         \n";
        hangman[4]="\n--------------------\n|\t\t|\n|\t\t0\n|\t              \n|\t         \n";
        hangman[3]="\n--------------------\n|\t\t|\n|\t\t \n|\t              \n|\t         \n";
        hangman[2]="\n--------------------\n|\t\t \n|\t\t \n|\t              \n|\t         \n";
        hangman[1]="\n                    \n|\t\t \n|\t\t \n|\t              \n|\t         \n";
        hangman[0]="\n                    \n \t\t \n \t\t \n \t              \n \t         \n";

        Console.WriteLine("Welcome to the game of hangman!");
        string gameMode = "";
        // Console.Write("Do you want to play HARD, MEDIUM, or EASY mode? ");
        // gameMode = Console.ReadLine().ToLower();
        // ignore for now, unfinished and probably don't have time to sort out
        

        string answer=randomWord();
        while(answer.Length<4){ //get an answer larger than 3 of length
            answer=randomWord();
        }

        string []WrongAnswers=new string [10];
        string[] userInputs=new string[50];
        int InputsCounter=0;
        int WrongAnswersCounter=0;

        
        
        
        int NumOfWrongs=0;
        char []userResult=new char[answer.Length];
        string userInput;
        bool gameEnds=false;    //variable to show if game ends
        int[] temp;             //to hold results from ArrayCheck

        //loop to fill up the answer with underscores ('_')
        for (int i=0;i<answer.Length;i++){
            userResult[i]='_';
        }

        Console.Write("Your word is:");
        Console.WriteLine(userResult);
        
        while(!gameEnds){
            Console.Write("Your current word is:");
            Console.WriteLine(userResult);
            Console.Write("Please enter your guess:");
            userInput = Console.ReadLine();
            Console.WriteLine();

            if (userInput== null){
                Console.WriteLine("Please enter something");
                continue;
            }

            // the user inputted multiple letters that are not the word
            if (userInput.Length > 1 && userInput.Length != answer.Length)
            {
                Console.WriteLine("Please enter a valid guess:");
                continue;
            }
            
            //The user inputted the word/letter already
            if(IsInArray(userInputs,userInput))
            {
                Console.WriteLine("Please enter a new value instead of inputting the same");
                Console.WriteLine("Available letters:");
                drawKeyboard(WrongAnswers, userInputs, keyboard);
                continue;
            }

            userInputs[InputsCounter]=userInput;
            InputsCounter++;

            if(userInput.Length==1){    //usual user guess -> one letter
                
                temp=Arraycheck(answer,userInput);
                if(temp[0]==-1){    //guess is wrong
                    WrongAnswers[NumOfWrongs]=userInput;

                    NumOfWrongs++;
                    
                    Console.WriteLine("The guess is wrong!");
                    Console.Write("You are currently in your number ");
                    Console.Write(NumOfWrongs);
                    Console.Write(" mistake, you have ");
                    Console.Write(9-NumOfWrongs);
                    Console.WriteLine(" mistakes left");
                    Console.Write("Hangman is attached below:");
                    Console.Write(hangman[NumOfWrongs]);

                    WrongAnswers[WrongAnswersCounter]=userInput;
                    WrongAnswersCounter++;
                    

                    
                   
                }else{  //guess letter is right
                    for (int i=0;i<temp.Length;i++){        //change the '_' into a word
                        userResult[temp[i]]=System.Convert.ToChar(userInput);
                    }

                    Console.WriteLine("Your guess is right!");
                    Console.Write("You are currently in your number ");
                    Console.Write(NumOfWrongs);
                    Console.Write(" mistake, you have ");
                    Console.Write(9-NumOfWrongs);
                    Console.WriteLine(" mistakes left");

                    if(CheckIfWin(answer,new string(userResult))){ //check if user outright won
                        gameEnds=true;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your guess is right!");
                        Console.Write("You win!\n");
                        Console.ResetColor();
                        
                    }
                }
            }else{//whole word guess
                if(CheckIfWin(answer,new string(userInput))){ //check if user outright won
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your guess is right!");
                    Console.Write("You win!\n");
                    Console.ResetColor();
                    gameEnds=true;
                }else{  
                    //whole word guess is wrong
                    NumOfWrongs++;
                    Console.WriteLine("The guess is wrong!");
                    Console.Write("You are currently in your number ");
                    Console.Write(NumOfWrongs);
                    Console.Write(" mistake, you have ");
                    Console.Write(9-NumOfWrongs);
                    Console.WriteLine(" mistakes left");
                    Console.Write("Hangman is attached below:");
                    Console.Write(hangman[NumOfWrongs]);
                }
            }
            if(CheckIfDead(NumOfWrongs)){
                gameEnds=true;
                losingScreen(answer);
            }
            Console.WriteLine("");
            //output all the wrong answers every loop
            Console.WriteLine("Available letters:");
            drawKeyboard(WrongAnswers, userInputs, keyboard);
        }
    }
}
