using System; class
Program {public static void
Main(string[] args){

  //"string[] word_haiku, the
  //name given to all of the
  //array element"
    
string[] word_haiku1 = { 
"I", "a", "an", "the", "are", "all", "if",
"of", "so" }; 
  
string[] word_haiku2 = { 
"highlight", "applied", "mountain", //I
"coffee", "voucher", //think
  
"locate", "basket" }; //I
//might have taken this joke
//to far and now want
  
string[] word_haiku3 = {
"insurance", "library", //to
"piano", //go back
  
"cigarette", //i'm
"property", "irony", //not
"explicit", "factory" };

string[] word_haiku4 = { 
"discovery", //sure what to
"manufacture", //put
  
"emergency", //here,
"electronics", //and as the
"variation", //words
  
"conspiracy", //get
"favorable" }; //longer I
//am gaining space.
  
string[] word_haiku5 = { 
"administration", //and i'm
"deteriorate", 
  
"supplementary", 
"anticipation", //starting
"environmental", 
  
"defenestration" };
//to panic because haikus
//were never designed
  
string[] word_haiku6 = { 
"revolutionary", //for
//the english language,

//and japanese
"hypnothize", //can
//be much easier

//to cram tons of words
"identification", //in
//and im starting to

//i've started feeling -
"Disassociation", //- in
//long project poem

//after all of this - 
"Hospitalization", //- will
//be a good idea.

//i'm starting to feel -
"Hallucinogenic", //and
// my fingers ache.

//I'VE STARTED USING
"Capitalization" }; //THE
//WORDS FOR INSPIRA
    
string[] word_haiku7 = { 
"Sentimentalization", 
//TION. oh why did I

//think this was worth it.
"Oversimplification",
//c# is kinda

//hard, but syntax is
"Maneuverability",
//very humourous.

//this long poem is
"Decriminalization",
//depressing but I

//regret doing
"Microbiological",
//for entertainment

//it's just tedious.
"Indispensability",
//and taking a while

//to count all of the
"Unconventionality" };
//syllables, done

  //"int Num_haiku is
  // the number of items
  // in each arrays"
  
int Num_haiku1 = 
word_haiku1.Length
- 1; //TWO SLOTS!!
  
int Num_haiku2 =
word_haiku2.Length
- 1; //writing
  
int Num_haiku3 = 
word_haiku3.Length
- 1; //is hard.
  
int Num_haiku4 = 
word_haiku4.Length 
- 1; //this is
  
int Num_haiku5 = 
word_haiku5.Length 
- 1; //like my
  
int Num_haiku6 = 
word_haiku6.Length 
- 1; //first major
  
int Num_haiku7 = 
word_haiku7.Length 
- 1; //c#

  //"syllable() is the
  //functions being called
  //and has many var..."
    
syllable5( //so
word_haiku1, //thats neat I
word_haiku2, //guess.
  
word_haiku3, //there
word_haiku4, //is a lot
word_haiku5, //of
  
Num_haiku1, //free
Num_haiku2, //space here.
Num_haiku3, //I
  
Num_haiku4, //made
Num_haiku5); //made a haiku
//generator be-

  
syllable7( //-fore
word_haiku1, //and it was
word_haiku2, //not
  
word_haiku3, //good
word_haiku4, //or smooth
word_haiku5, //but
  
word_haiku6, //I
word_haiku7, //made it on
Num_haiku1, //an account

Num_haiku2, //from
Num_haiku3, //a school
Num_haiku4, //E-
  
Num_haiku5, //mail
Num_haiku6, //which is now
Num_haiku7); //gone
    
syllable5( //;( .
word_haiku1, //in retro-
word_haiku2, //spe-

word_haiku3, //c-
word_haiku4, //t should have
word_haiku5, //made
  
Num_haiku1, //these
Num_haiku2, //var longer
Num_haiku3, //or
  
Num_haiku4, //short-
Num_haiku5); //er
//cause goddam does this

  //"console.Readkey();
  //make sure the program does
  //not exit too fast"

Console.ReadKey();
//suck so much to write out all
//of comments.
}

  //"random random ran-
  //dom random random random
  //random random ran-"
  
static Random Rand
= new Random(); //I should have plan-
//ned this out more than

  //"syllable_word()
  //function for syllables
  //used often"
  
static string //I
syllable_word(string[]
word_haiku, int //did.
  
Num_haiku){ //surpris-
//ingly c# was not made
//to be made into

int RandSyllable =
Rand.Next(0, Num_haiku);
return word_haiku

//haiku, but its fun-
[RandSyllable];} //-ney
//that it can do that.

  //"syllable5() one
  //of the major function
  //first - last sentence"
  
static void //I just
syllable5( string[] //haiku
word_haiku1, string[] 
  
word_haiku2, string[] 
word_haiku3, string[] //'d the
word_haiku4, string[] 
  
word_haiku5, int
Num_haiku1, int //rest
Num_haiku2, int

Num_haiku3, int 
Num_haiku4, int //of the
Num_haiku5){ //stuff

int RandSwitch = Rand.Next
(1, 6); switch (RandSwitch){ //and now
//i have to think of

case 1: //stuff to write
//which I now know is going to
//"one, one, one, one, one"

Console.WriteLine(
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)}");
        
break;   //"pretend the last
  //line was perfectly done ok
  //else theres an error"

case 2: //be hell on
//earth, but i'm slowly get-
//"one, one, two, one" 1
        
Console.WriteLine(
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)}");

break; //"same with this one
//and all subsequent
//similar lines"

case 3: //ting there, sigh.
//I'm a big fan of buldok
//"one, two, one, one" 1

Console.WriteLine(
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)}");

break; //"I have
//not used 3 5 3
//format yet"
  
case 4: //pot
//noodles cause they taste
//"two, one, two"
  
Console.WriteLine(
$"{syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)}");
   
break; //really
//but are also
//extremely

case 5: //quite
//spicy, but i've eat-
//"two, three" en
        
Console.WriteLine(
$"{syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku3, Num_haiku3)}");
            
break; case 6:
//so many that I
//"three, two" got

Console.WriteLine(
$"{syllable_word(word_haiku3, Num_haiku3)} {syllable_word(word_haiku2, Num_haiku2)}");
                
break; //used to
//the spice and my stomach
//hates me.

case 7:
//all instant noodle
//"four, one" are

Console.WriteLine(
$"{syllable_word(word_haiku4, Num_haiku4)} {syllable_word(word_haiku1, Num_haiku1)}");
                
break; case 8:
//good by default,
//"one, four" I

Console.WriteLine(
  $"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku4, Num_haiku4)}");
                
break; case 9:
//have eaten
//"five" a few
          
Console.WriteLine(
$"{syllable_word(word_haiku5, Num_haiku5)}");
                
break;}} //instant
//noodles I did
//not like.

  //"syllable7()
  //the function for the middle
  //of the haikus"

static void
syllable7(
string[] //break two
  
word_haiku1, string[]
word_haiku2, string[] //what was
word_haiku3, string[] 
  
word_haiku4, string[] 
word_haiku5, string[] //I go-
word_haiku6, string[] 
  
word_haiku7, int 
Num_haiku1, int //ing on
Num_haiku2, int 
  
Num_haiku3, int 
Num_haiku4, int //abou-
Num_haiku5, int 

Num_haiku6, int 
Num_haiku7){ int //t
RandSwitch = Rand.Next
  
(1, 6); switch (RandSwitch){
//I think i'm never gonna write a
//haiku again.
  
case 1: //or maybe
//"one, one, one, one, one, one, one,"
Console.WriteLine(
  
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)}");
  
break; case 2: //in like
//"one, one, two, one, one, one" 1
Console.WriteLine(
  
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)}");

break; case 3: //a mon-
//"one, two, one, one, two" th or
Console.WriteLine(
  
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)}");

break; case 4:
//"two, three, two" two.
//Replit A-

Console.WriteLine(
$"{syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku3, Num_haiku3)} {syllable_word(word_haiku2, Num_haiku2)}");

break; case 5:
//"one two one three" I
//sucks

Console.WriteLine(
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku3, Num_haiku3)}");
              
break; case 6:
//"one four two" and is
//not meant
          
Console.WriteLine(
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku4, Num_haiku4)} {syllable_word(word_haiku2, Num_haiku2)}");

break; case 7: //for
//"two, one, four" haikus at all.
//if your reading this

Console.WriteLine(
$"{syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku4, Num_haiku4)}");
                
break; case 8:
//"two, four one" wow! that
//must suck so
  
Console.WriteLine(
$"{syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku4, Num_haiku4)} {syllable_word(word_haiku1, Num_haiku1)}");
                
break; case 9:
//"five, two" but no-
//t as mu-
  
Console.WriteLine(
$"{syllable_word(word_haiku5, Num_haiku5)} {syllable_word(word_haiku2, Num_haiku2)}");
                
break; case 10:
//"two, five" ch as it 
//sucked
  
Console.WriteLine(
$"{syllable_word(word_haiku2, Num_haiku2)} {syllable_word(word_haiku5, Num_haiku5)}");
              
break; case 11:
//"one, five, one" to write this.
Console.WriteLine(
  
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku5, Num_haiku5)} {syllable_word(word_haiku1, Num_haiku1)}");
                
break; case 12:
//"one, six" might
//upload
  
Console.WriteLine(
$"{syllable_word(word_haiku1, Num_haiku1)} {syllable_word(word_haiku6, Num_haiku6)}");
              
break; //this
//to github
case 13:

//so nobo
//"seven" -dy steals
//this junk.
        
Console.WriteLine(
$"{syllable_word(word_haiku7, Num_haiku7)}");
              
break;}}} //made
//by hyzenthaly
//good day! cough.