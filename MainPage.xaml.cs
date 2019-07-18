using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Bestiary.Classes;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Bestiary
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Entry[] Beasts=new Entry[8];
            Entry[] CursedOnes = new Entry[7];
            Entry[] Draconids = new Entry[10];
            Entry[] Elementa = new Entry[11];
            Entry[] Hybrids = new Entry[9];
            Entry[] Insectoids = new Entry[13];
            Entry[] Necrophages= new Entry[16];
            Entry[] Ogroids = new Entry[9];
            Entry[] Relicts = new Entry[20];
            Entry[] Specters = new Entry[16];
            Entry[] Vampires = new Entry[13];
         
            

            /*PERSONAL NOTE
             * I MUST SET THE VARIATIONS AFTER FINISHING ALL ENTRIES"*/



            //Declaration of all creatures


            /*Click to expand*/{

                /*CONSTRUCTOR:
                *Name
                *Description...
                *...Loot
                *Occurrence
                *Susceptibility
                *ImagePath*/
                

                /*--------------BEASTS-----------------------

                Click to Expand*/{

                    //BEAR
                    Beasts[0] = new Entry(
                        "Bear"
                        , "Bears are generally found far from human habitation, either in the high mountains or in the deep woods. " +
                        "Opposite of dogs and wolves, bears are solitary creatures, which is probably for the best considering how strong a " +
                        "killing machine they are. It is simple enough a thing to avoid fighting a bear, but that is not always the case. A " +
                        "bear may be clumsy but they run at high speeds despite their bulky sizes, so running away may not always be an option, " +
                        "especially if you have already angered the bear."
                        , "Bear Fat, Bear Hide, Raw Meat, and White Bear Hide"
                        , "Velen, Skellige, White Orchard, and Toussaint"
                        , "Beast Oil, and Quen"
                        , "Assets\\Bear.png");

                    //Phanter
                    Beasts[1] = new Entry(
                        "Phanter"
                        , "Panthers are dangerous predators found in forests and other woodlands. They are quick, agile and, like all cats, diabolically " +
                        "cunning. In many less-than-thoroughly-urbanized areas, folk still believe panthers are the stranded souls of those who die in their sleep. " +
                        "Superstition thus holds anyone perishing in this way should be dragged to the nearest woods and left there without a burial. The panther-spirit of the " +
                        "deceased may then devour its own body, thereby passing on to the nether realms."
                        , "Fur Scrap, Cured Leather, and Raw Meat"
                        , "Toussaint"
                        , "Beast Oil"
                        , "Assets\\Phanter.png");

                    //Wild Boars
                    Beasts[2] = new Entry(
                        "Wild Boars"
                        , "These woodland beasts are as \"wild\" – untamed, nasty and aggressive – as their name indicates. To this day, many peasants in outlying Kaedweni villages believe " +
                        "wild boars persist on a diet of young maids, though in truth they most often slate their hunger with roots and acorns. Do not think this vegetarian diet makes them harmless, " +
                        "however. In fact, these animals' stout build and sharp teeth render them veritable fur-covered combat machines. Mother Nature has additionally equipped them with dual pairs of " +
                        "tusks - upper \"pipes\" and lower \"sabres\" - and this weaponry's sum effect is to make the beasts the terrors of the woods, a threat to all who venture or dwell there, human, humanoid " +
                        "and otherwise. Boars also have hard, club-like snouts, which some peasants call their \"whistles, \" though no boar has ever been heard to make such a noise. Instead, they emit a characteristic " +
                        "grunt, which sounds to some like the snoring of an extremely overweight man. Another peasant belief claims boars have extremely prickly natures, and, if offended, will vent their anger by knocking " +
                        "down fences and gobbling up potatoes. Though they sometimes live alone, boars usually appear in small groups of 3 to 5 specimens."
                        , "Boar Tusk, Boar Pelt,Raw Meat"
                        , "Gustfields, and Toussaint"
                        , "Northern Wind, Beast Oil, Igni, and Yrden"
                        , "Assets\\WildBoar.png");

                    //BigBadWolf
                    Beasts[3] = new Entry(
                        "Big Bad Wolf"
                        , "The Big Bad Wolf is a large lupine humanoid who inhabits the illusory Land of a Thousand Fables, created by Artorius Vigo. He is based on a homonym figure from Nordling folk tales and served " +
                        "as a childhood playmate for Anna Henrietta and Sylvia Anna, two daughters of Toussaintois duke."
                        , "Magic Dust, Red Mutagen, Fake Tooth, Corkscrew, and Bottle Caps"
                        , "Land of a Thousand Fables"
                        , "Devil's Puffball, and Beast Oil"
                        , "Assets\\BigBadWolf.png");

                    //The Beast of Beauclair
                    Beasts[4] = new Entry(
                        "The Beast of Beauclair"
                        , "Eyewitnesses to gruesome monster attacks always have a hard time describing the creature in question. The beasts move quickly and often attack at night, while the witnesses are terrified and primarily " +
                        "concerned with fleeing for their lives. As a result, witchers quite often have no inkling what creature they face until they find tracks or otherwise establish something for themselves. Such was the case with " +
                        "the Beast tormenting Beauclair. Geralt knew it was deadly, elusive and fiendishly clever. Everything else he heard was clearly the product of imaginations fed by fear of a dangerous predator. When Geralt identified the Beast, " +
                        "he discovered it was a higher vampire, meaning one of the most difficult foes a witcher can come to face. Higher vampires are superhumanly strong and fast.They can turn completely invisible, and each comes with its own personalized " +
                        "set of talents and abilities perfected through centuries of existence. When Geralt realized he was dealing with such a creature, he swore foully and realized the rumors about the Beast had not been exaggerated in the slightest."
                        , null
                        , "Toussaint"
                        , "Vampire Oil, Black Blood, and Quen"
                        , "Assets\\TheBeastOfBeau.png");

                    //Wolves
                    Beasts[5] = new Entry(
                        "Wolves"
                        , "Once upon a time wolves were the absolute rulers of the forest. Men used them to frighten children, while adults, too, trembled at the sound of their howling. Post-Conjunction monsters not only pushed wolves into the deepest wilds but " +
                        "also took over their place in human nightmares. Yet this does not mean the old predators ceased to be a danger. Wolves do not have a drop of magic within them, breathe no fire and spit no acid, but that in no way stops them from killing unwary travelers and hunters."
                        , "Raw Meat, Wolf Hide, Wolf's Liver, and Dog Tallow"
                        , "Velen, White Orchard,Skellige, and Toussaint"
                        , "Beast Oil"
                        , "Assets\\Wolf.png");

                    //Dogs
                    Beasts[6] = new Entry(
                        "Dogs"
                        , "Some claim dogs are reflections of their masters. A well-treated pet repays his owner with loyalty and trust, whereas an ill-treated one repays this treatment in kind as well, meeting yells with barks and kicks with bites. Since there is an abundance of bad men, so, too, " +
                        "is there an abundance of bad dogs. Most dangerous of all are the vagrant mutts who have lost all respect for men and developed a taste for blood and carrion. Dogs usually attack in packs, choosing isolated victims, especially ones in whom they sense some kind of weakness.Packs of " +
                        "rabid dogs usually only dare attack children, drunkards, the elderly and cripples.Yet when backed into a corner, they will defend themselves with frothing bites and sharp claws against all and sundry."
                        , "Dog Tallow, Raw Meat"
                        , "Velen, Novigrad, and Skellige"
                        , "Beast Oil"
                        , "Assets\\Dog.png");

                    //Three Little Pigs
                    Beasts[7] = new Entry(
                        "Three Little Pigs"
                        , "The three little pigs are perfect examples of a rather unfortunate phenomenon. Leave even a kind-hearted, warm, naively benign creature to fend for itself, and it won't remain so benign for long. The three little pigs from the Land of a Thousand Fables were left for years without Artorius " +
                        "Vigo's supervision. During this time they went completely feral, transforming into three wild boars which attacked anyone who dared approach their ruined home."
                        , "Magic Dust"
                        , "Land of a Thousand Fables"
                        , "Beast Oil"
                        , "Assets\\ThreePigs.png");
                }

                /*--------------Cursed Ones------------------
                  
                Click To Expand*/{

                    //ARCHESPORE
                    CursedOnes[0] = new Entry(
                        "Archespore"
                        , "Archespores look like gigantic, aesthetically unpleasing flowers with some of the traits of exceptionally cruel and bloodthirsty sundews. They are, however, far more dangerous that even the most colossal sundew. Their peculiar appearance makes them practically impossible to discern amidsts other " +
                        "plants. By the time one draws close enough to realize what they are, it is often too late to flee. According to popular belief, archespores are cursed plants grown in soil fertilized by the blood of the dying.They are most often found in places which in the past saw pogroms, bloody rituals or cruel " +
                        "murders Four types of archespore have been catalogued to date, differing from one another in terms of coloring: brown(the least dangerous), green and purple(the most dangerous).The final variant, said to have been cultivated by mages from Ban Ard, is the yellow archespore, whose strength is similar to " +
                        "that of its green - colored - cousins. Regardless of color, all archespores fight using similar methods: attacking with powerful, jaw - like leaves.If their victim is out of reach, they can also spray caustic acid which if it makes any contact whatsoever with the skin, can provoke a reaction similar to that " +
                        "caused by severe poisoning."
                        , "Archespore Juice, Archespore Tendril, and Monster Spore"
                        , "Toussaint"
                        , "Cursed Oil, Aard, and Igni"
                        , "Assets\\Archespore.png");

                    //BOTCHLINGS
                    CursedOnes[1] = new Entry(
                        "Botchlings"
                        , "otchlings are perhaps the most repulsive creatures a witcher will ever have the displeasure of meeting. Born of dead, unwanted babies discarded without a proper burial, their appearance is that of a partially-decayed fetus, their unformed flesh twisted with hate, fear and malice. These hideous creatures feed " +
                        "on the blood of pregnant women, driven by a mad hunger that most often leads to their victim's death. A botchling will emerge from its lair at night to lurk by the bedside of an expectant mother, draining her strength and that of her unborn progeny as she sleeps.A woman thus beleaguered first suffers from troubling " +
                        "dreams, then fever, delirium and a general weakening of the flesh.After a few such nights she is enfeebled and unable to defend herself - it is then the botchling attacks directly, sinking its long, sharp fangs into her body and drinking her blood until mother and fetus perish together. A botchling stands around a " +
                        "foot and a half in height, but, when threatened and if gorged with blood, it can change form.At such times it grows into a deformed man, hunched over and striding, ape-like, on its forearms.Stronger and fiercer after this alteration, it hurls itself into direct, physical combat, gnashing at its opponent or attacking " +
                        "him with sharp claws. A botchling's curse can be lifted by transforming it into a lubberkin - a guardian spirit of the hearth that watches over the family it never knew in the house it never could call home."
                        , "Lesser Red Mutagen, Monster Ear, Monster Blood, Necrophage Hide, Rotting Flesh, and Monster Brain"
                        , "Crow's Perch"
                        , "Cursed Oil, and Axii"
                        ,"Assets\\Botchling.png");

                    //ULFHEDINN
                    CursedOnes[2] = new Entry(
                        "Ulfhedinn"
                        , "Ulfhedinn are a breed of werewolf found mainly in Skellige. The harsh and barren conditions of the isles might explain why they primarily hunt men and are " +
                        "stronger than their continental brethren. Older and particularly dangerous ulfhedinn are called olrefs. Only a few daring warriors in Skellige history have " +
                        "managed to defeat an ulfhedinn, and each of them is commemorated in ballads as a hero to this day. Like werewolves, ulfhedinn and vorefs are active at night, " +
                        "particularly when the moon is at its fullest.Fast, strong, and amazingly resilient, these creatures kill with disturbing ease.Silver blades should be brought " +
                        "against them, as should Devil's Puffball. Take note that when near death the ulfhedinn becomes particularly dangerous and will attack with doubled fury, while " +
                        "calling on wolves to come to its rescue."
                        , "Werewolf Hide, Werewolf Mutagen, Werewolf Saliva, and Monster Essence"
                        , "Skellige"
                        , "Moon Dust, Devil's Puffball, Cursed Oil, and Igni"
                        ,"Assets\\ulfhedinn.png");

                    //BERSERKERS
                    CursedOnes[3] = new Entry(
                        "Berserkers"
                        , "Skellige legends speak of men known as berserkers who transform into bears when overwhelmed by battle rage. In doing so, they lose all self-awareness and are " +
                        "driven by a bloodlust which they must satiate in order to return to human form. Few believe these blood-curdling tales, however, not even in Skellige, where the " +
                        "inhabitants usually treat even the least probable legends with the utmost gravity. This indicates either that berserkers are in fact mere figments of mead-sodden " +
                        "imaginations, or else that they have learned to hide their abilities from the rest of the islanders. The skalds' ballads indicate a berserker transformed in the " +
                        "heat of battle cannot be distinguised from a true-born bear. Only minute anatomical details - such as the shape of their tongues and teeth - reveal their secret." +
                        " Descriptions of their fighting prowess paint them as invulnerable to pain and able to heal any wound received almost at once. If these men - turned - bears truly " +
                        "do exist, one can suppose that, like werewolves and lycanthropes, they are particularly vulnerable to oils that harm cursed creatured. But if we are to give " +
                        "credence to ancient songs about these creatures' deeds, about the mass murders and massacres they have committed, we can only hope that no witcher will have to " +
                        "test this hypothesis."
                        , "Bear Fat, Berserker Hide, and Raw Meat"
                        , "Skellige, and Vildkaarl's Village"
                        , "Devil's Puffball, Cursed Oil, Quen, and Igni"
                        , "Assets\\Berserker.png");

                    //LUBBERKIN
                    CursedOnes[4] = new Entry(
                        "Lubberkin"
                        , "A lubberkin is a friendly household guardian spirit created from a botchling through Aymm Rhoin, an elven naming ritual, during which it is given a proper name and " +
                        "a burial under the hearth of the family estate. A lubberkin looks very similar to a botchling, though the main difference being its ghost-like, glowing, white aura and " +
                        "relatively passive behavior."
                        ,null
                        ,null
                        ,null
                        ,"Assets\\Luberkin.png");

                    //WEREWOLF
                    CursedOnes[5] = new Entry(
                        "Werewolf"
                        , "Werewolves are creatures with both men and wolves inside them. When in beastly form, they take the worst traits of each: the wolf's drive to kill and hunger for raw flesh " +
                        "and the man's cruel and calculating intelligence. A werewolf's condition comes about through a curse, and the transformations happen outside his conscious control. When he reverts " +
                        "to human form, he has no memory of his deeds – otherwise he would surely go mad and take his own life. Werewolves are active at night, particularly when the moon is full.Though they " +
                        "hunt alone, when threatened they will summon wolves to aid them.Werewolves rarely feel the need to flee, for few adversaries put up much of a fight against them.They strike as swiftly " +
                        "as lightning with claws sharp as razors and regenerate any damage received in mere moments.When fighting werewolves a witcher should wield a blade covered in oil harmful to the cursed " +
                        "and have a large supply of Devil's Puffballs handy. A werewolf's curse can at times be lifted, yet there is no universal, surefire method for doing this. A witcher seeking to undertake " +
                        "such a task must there equip himself with a great deal of patience – and sturdy armor."
                        , "Werewolf Hide, Werewolf Mutagen, and Werewolf Saliva"
                        , "Velen, and Skellige"
                        , "Moon Dust, Devil's Puffball, Cursed Oil, and Igni"
                        , "Assets\\Werewolf.png");

                    //THE TOAD PRINCE
                    CursedOnes[6] = new Entry(
                        "The Toad Prince"
                        , "Timeless tales always carry within them a grain of truth. The legend of the frog prince is no exception, or at least that's what the folk of Oxenfurt wished to believe when they found out " +
                        "a monstrous toad lurked in their city sewers. The women who hunted it in search of romance and a better life, however, found their tales had a most unhappy ending. The creature they encountered " +
                        "was no small, sweet frog but a bloodthirsty beast, who not only did not let them in for a kiss, but instead greedily devoured them and anything else that strayed into its slime-covered lair."
                        ,null
                        ,"Oxenfurt Sewers"
                        ,"Northern Wind, Golden Oriole, Cursed Oil, and Yrden Sign"
                        ,"Assets\\Toad.png");

                   


                }

                /*--------------Draconids--------------------

                Click To Expand*/{

                    //BASILISKS
                    Draconids[0] = new Entry(
                        "Basilisks"
                        , "Contrary to popular belief, basilisks cannot turn anything to stone with their gaze. That is small comfort, however, given that their acid, venom, claws and " +
                        "teeth provide them many other ways to kill. Basilisks love dark, damp places such as cellars, caves and city sewers.They hunt by day, waiting patiently in hiding " +
                        "for their prey to come, then jump out in a flash to unleash a deadly attack. When preparing to fight such a creature one should drink Golden Oriole, which will " +
                        "provide resistance to its venom, and also prepare Dancing Star or shrapnel bombs, which work particularly well against basilisks. Basilisk leather is a highly - " +
                        "valued material used to make fashionable shoes and women's handbags. For this reason many men, their courage girded by goldlust, take to hunting them. Most of these " +
                        "hunts end in disaster, but some do manage to bag their prey, which has led to a drastic decline in this creature's numbers in recent years.Some mages and druids are " +
                        "of the opinion that basilisks should be included in programs meant to safeguard dying species.Everyone else thinks those mages and druids have gone completely mad."
                        , "Basilisk Venom, Basilisk Hide, and Basilisk Mutagen"
                        , "Velen"
                        , "Golden Oriole, Grapeshot, Draconid Oil, and Aard"
                        , "Assets\\Basilisk.png");


                    //ROYAL WYVERNS
                    Draconids[1] = new Entry(
                        "Royal Wyverns"
                        , "A hunter who knows his prey's habits and behavior will rarely return from his hunt empty-handed. To know what forest paths deer are like to trod, to know in what muck " +
                        "boars will wallow, to guess when a hare will emerge from its burrow - that is half the battle.What most men do not know is that some monsters also possess such knowledge.For " +
                        "example, a royal wyvern from Velen had learned the danger of exposing itself to human eyes and arrows by flying high to pick out its prey from afar.Instead, it would lurk by " +
                        "the roadside and wait for military transports. In this way it grew fat on salted pork and beer, expanding until it resembled a dragon more than other, lesser members of its own kind."
                        , "Wyvern Trophy, Wyvern Mutagen, Wyvern Egg, and Anathema"
                        , null
                        , "Golden Oriole, Grapeshot, Draconid Oil, and Aard"
                        , "Assets\\royal.png");

                    //SLYZARD MATRIARCHS
                    Draconids[2] = new Entry(
                        "Slyzard Matriarchs"
                        , "If you ever find yourself facing a monster that breathes fire, strikes with a tail tipped with venomous spines, bites with sharp teeth and swipes with even sharper claws and tends to " +
                        "knock its prey to the ground with a sonic blast, then you are fighting a slyzard. With an asernal like that, it comes as no surprise folk often mistake these draconids for dragons. " +
                        "Yet the experts (meaning witchers) know slyzards constitute an entirely seperate species, much smaller than dragons and far less dangerous. With one exception: slyzard females in " +
                        "mating season, or, even worse, just after laying their eggs. When fighing such individuals, my suggestion is to get as far as possible from the danger as quickly as possible, preferably " +
                        "by running, at full tilt, without looking back."
                        , "Slyzard Trophy"
                        , "Toussaint"
                        , "Grapeshot, Draconid Oil, Aard, and Quen"
                        , "Assets\\Slyzard.png");

                    //COCKATRICE
                    Draconids[3] = new Entry(
                        "Cockatrices"
                        , "Foolish superstitions claim cockatrices, like basilisks, can kill with their gaze alone. That is utter nonsense, however, a cockatrice's gaze being no more dangerous than that of an angry " +
                        "goose. One should instead watch out for it's sharp beak and long tail, which it can whip to murderous effect. Cockatrices thrive in dark caves, abandoned ruins, cobwebbed dungeons and old " +
                        "basements.Though small compared to griffins and manticores, they are more than capable of killing anyone who stumbles across them in a dark corridor. Cockatrices do not shun direct fights, " +
                        "in which they strike furiously with wing and tail in an attempt to exhaust their foes. Blows from their beaks are especially dangerous, as they aim with deadly precision at exposed flesh and " +
                        "vital organs and leave bleeding, life - threatening wounds.When fighting them one should make liberal use of draconid oil as well as Grapeshot, whose shrapnel will pierce their delicate wings with ease."
                        , "Cockatrice Egg, Cockatrice Mutagen, Cockatrice Stomach, Cockatrice Trophy, and Monster Carapace"
                        , "Velen, and Redania"
                        , "Grapeshot, Draconid Oil, and Aard"
                        , "Assets\\Cockatrice.png");

                    //SHRIEKER
                    Draconids[3] = new Entry(
                        "Shrieker"
                        , "The monster tormenting the residents of Crow's Perch turned out to be a particularly nasty cockatrice. Geralt was not surprised the baron's men had been unable to stop it. They could not possibly" +
                        " withstand the surgical precision of its strikes, which slice open arteries and provoke an outpouring of blood only the Swallow potion could hope to stop. Neither did they know to force it to the" +
                        " ground with a crossbow, a bomb or a Sign, and then evade its charge by rolling under the monster's outstretched wing.Just when it seemed the villagers would have to learn to live in the shadow of " +
                        "a bloodthirsty beast, to always look to the sky with fear, the witcher arrived - and put an end to the shrieker for good."
                        , "Cockatrice Egg, Cockatrice Mutagen, Cockatrice Stomach, Cockatrice Trophy, Dwarven Axe, Monster Carapace, Monster Feather, and Monster Saliva"
                        , "Cave near Crow's Perch"
                        , "Grapeshot, Draconid Oil, and Aard"
                        , "Assets\\Shrieker.png");

                    //FORKTAIL
                    Draconids[4] = new Entry(
                        "Forktails"
                        , "Forktails owe their quaint name to the long sharp growths at the tip of their tails. A blow from this weapon can slice an oaken shield in two – along with the arm that was carrying it. Thus, though " +
                        "its name conjures images of cutlery, fighting a forktail is nothing like a dinner party and ends in death rather than dessert."
                        , "Forktail Mutagen, Forktail Hide, Dragon Scales, Monster Liver, Monster Eye, and Raw Meat"
                        , "Velen, Skellige, and White Orchard"
                        , "Golden Oriole, Grapeshot, Draconid Oil, and Aard"
                        , "Assets\\Forktail.png");

                    //SILVER BASILISK
                    Draconids[5] = new Entry(
                        "Silver Basilisk"
                        , "Silver Basilisks were once a dominating species, especially in the region of Toussaint where they were very common around the year 1100. Their extirpation in the duchy, and possibly near-extinction " +
                        "in the world as a whole, is chiefly due to hunting by humans for the monsters' silver-colored hides.In the year 1275, the last regulus platinum specimen in Toussaint (known as the Great White Terror) " +
                        "attacked passing merchant caravans, primarily in the northern parts of the duchy. However, due to being the last specimen, he is vehemently protected by Count Borhis di Salvaress."
                        , null
                        , "Toussaint"
                        , "Golden Oriole, Draconid Oil, Aard, and Igni"
                        , "Assets\\Silver.png");

                    //THE DRAGON OF FYRESDAL
                    Draconids[6] = new Entry(
                        "The Dragon of Fyresdal"
                        , "Few truly know what a dragon looks like, for those who have seen one up-close rarely have a chance to share their impressions. That is why people are forever mistaking other monsters for dragons. " +
                        "This was the case in Fyresdal, where the so-called dragon wreaking havoc turned out to be a forktail. Yet this mistaken attribution did not mean there was no reason to worry.The forktail harassing " +
                        "Fyresdal was a particularly vile representative of its kind, one equipped with an endless store of deadly venom.Fighting it without first drinking a regenerative potion or a poison antidote would be " +
                        "tantamount to suicide."
                        , "Dragon Scales, Forktail Mutagen, Forktail Hide, Forktail Trophy, Monster Bone, Monster Heart, and Monster Tongue"
                        , "Abandoned Siege Tower Outside Fyresdal"
                        , "GOlden Oriole, Grapeshot, Draconid Oil, and Aard"
                        , "Assets\\Fyresdal.png");

                    //DRACOLIZARD
                    Draconids[7] = new Entry(
                        "Dracolizards / Slyzards"
                        , "Slyzards are often mistaken for wyverns or forktails. Yet make no mistake: slyzards are nasty, terribly dangerous beasts, and confusing them for wyverns will end very badly for the confuser. While " +
                        "a wyvern can tear apart and devour an untrained man in seconds, only a slyzard can first bake him to a crisp with a waft of fiery breath. Slyzards are keenly aggressive and attack from both ground and " +
                        "air.Their goal during a fight is to get close enough to their foe to injure it with a breath of fire or knock it down with a sonic blast.Like wyverns, slyzards also attack with venom - spiked tails. " +
                        "Slyzards like to disengage mid - fight to fly into the air and plummet down at high speed while spewing out balls of fire. Right before these igneous missiles emerge, you can observe a fiery ball forming " +
                        "in the monster's maw. While airborne, a slyzard can also attack with its claws and teeth. It is worthwhile to employ the Aard and Igni Signs to force slyzards to the ground. They are not, however, vulnerable " +
                        "to burning.Before tackling one of them, be sure to coat your blade in draconid oil."
                        , "Slyzard Scale Plate"
                        , "Dragon Mountains Near, Barefield, and Toussaint"
                        , "Grapeshot, Draconid Oil, Aard, and Quen"
                        , "Assets\\Dracolyzard.png");

                    //WYVERNS
                    Draconids[8] = new Entry(
                        "Wyverns"
                        , "Wyverns are often mistaken for dragons, and, though they are much smaller than their more famous kin and do not breathe fire, they are likewise extremely dangerous monsters. Especially feared are the " +
                        "so-called royal wyverns who, like their namesake monarchs, are exceptionally ornery and extremely deadly."
                        , "Dragon Scales,Monster Blood, Monster Bone, Monster Brain, Monster Claw, Monster Eye, Wyvern Egg, Wyvern Hide, Wyvern Mutagen, and Wyvern Trophy"
                        , "Wyverns have been spotted nesting in northeastern Velen, though it must be stressed that these beasts are highly-adaptable, and have been sighted across the entire Continent and the Skellige isles."
                        , "Golden Oriole, Grapeshot, Draconid Oil, Aard"
                        , "Assets\\Wyvern.png");


                }

                /*--------------Elementa---------------------

                Click To Expand*/{

                    //DJIN
                    Elementa[0] = new Entry(
                        "Djin"
                        , "A djinn is a powerful air spirit, a condensation of the power of that element endowed with consciousness and character - the latter usually nasty. " +
                        "According to legend, djinn can grant even the most far-fetched wishes, though they do so very begrudgingly. Unusually powerful mages can capture and " +
                        "tame these beings.The mage can then draw on its energy, using it to cast spells without having to call on Power from traditional sources.Only a sparse " +
                        "handful have managed this feat, however, for djinn fight to avoid such a fate with stubborn determination.To imprison a djinn and bend it to one's will, " +
                        "one must first weaken it - and that is no easy feat. Fighting a djinn is extraordinarily difficult. They can fling off spells in an instant that the most " +
                        "accomplished human mages could never cast with years of preparation.What's more, by manipulating the element of air they can summon powerful storms, " +
                        "hurricanes, and gales. Luckily, as magic beings, they are vulnerable to silver - yet steel will do them no harm."
                        , null
                        , null
                        , "Dimeritium Bomb, and Elementa Oil"
                        , "Assets\\Djinn.png");

                    //GOLEMS
                    Elementa[1] = new Entry(
                        "Golems"
                        , "Golems are mindless matter brought to life by a spell. They obey their creator's orders without question. Their boundless strength, ability to withstand " +
                        "pain, endless patience and the fact that they neet not one jot of food or drink makes them the best servants or guards anyone could ask for. Once provoked, " +
                        "they will not tire of battle until they have either crushed their opponent or themselves crumbled to dust. Defeating a golem is extraordinarily difficult: " +
                        "for obvious reasons it does not bleed, it feels no fear or mercy and it is invulnerable to fire and poison.What's more, a golem's body is as hard as the " +
                        "rock it is sometimes heft out of, so even a silver blade will barely wound it.The monster's only weakness is acid – a blade covered in acrid oil can thus " +
                        "increase one's chances for victory. Golems use no weapons, for they have no need – their fists, weighing over a hundred pounds each, can crush solid granite " +
                        "with one hit.A blow from a golem should thus be avoided at all costs – there is no shield that can stop it, nor sword that can parry it.That is no easy task, " +
                        "for these creatures are able to move with surprising speed.Luckily, their enormous mass means they are not very agile – once a golem begins a charge, it cannot " +
                        "stop quickly, a fact experienced witchers use to their advantage."
                        ,"Golem's Heart, Infused Dust, Monster Essence, Monster Saliva, and Runestones"
                        ,"Elven Ruins and Caves (throughout the world)"
                        ,"Dimeritium Bomb, and Elementa Oil"
                        ,"Assets\\Golem.png");

                    //PIXIES
                    Elementa[2] = new Entry(
                        "Pixies"
                        , "Pixies might look like gentle, harmless creatures, yet in their case, the saying about appearances being deceiving fits all too perfectly. The pixies from " +
                        "the Land of a Thousand Fables were created to protect that magic place from intruders and ensure the ducal daughters, Sylvia Anna and Anna Henrietta, did not " +
                        "come to even the slightest harm. Thus whenever anyone else crossed the pixies' path, it ended badly for them, for pixies are aggressive, war-like creatures, " +
                        "created to kill, defend and fight till they can fight no more."
                        ,null
                        ,"Land of a Thousand Fables"
                        ,"Elementa Oil"
                        ,"Assets\\Pixies.png");

                    //EARTH ELEMENTAL
                    Elementa[3] = new Entry(
                        "Earth Elemental"
                        , "Earth elementals are made of mud, clay, sand and rock dust clumped together with water and brought alive with magic. While seemingly slow and ponderous, there " +
                        "creatures are nevertheless dangerous and should be avoided at all costs. Earth elementals can withstand a tremendous amount of punishment.Due to their enormous " +
                        "mass they are virtually impossible to knock off balance.They do not bleed nor feel any pain from poison or even fire. They kill men with astonishing ease – whether " +
                        "by smashing them with their fists or hurling enormous stones at them.Their only weakness is their vulnerability to dimeritium dust – thus before combat one should " +
                        "prepare a full arsenal of bombs containing this ingredient."
                        , "Elemental Essence, and Earth Elemental Mutagen"
                        , "Elven Ruins, Ermion's Laboratory in Kaer, and Trolde Citadel"
                        , "Dimeritium Bomb, and Elementa Oil"
                        , "Assets\\Earth.png");

                    //HOUND OF THE WILD HUNT
                    Elementa[4] = new Entry(
                        "Hound of the Wild Hunt"
                        , "Born, or so some experts believe, of magic ice crystal, the Hounds of the Wild Hunt race alongside their spectral masters. Like ravenous, feral dogs they are " +
                        "capable only of mindlessly attacking whatever crosses their path. The Hounds' chief weapons are their claws and teeth. Their battle tactics rely on knocking " +
                        "their opponents to the ground before tearing them to shreds. Badly wounded Hounds fall into a kind of frenzy that adds to their deadly might. These beasts also " +
                        "use their powers over the cold to freeze the ground around them and create sharp spikes of ice. Creatures born of frost,they feel pain from the Igni Sign, and " +
                        "there is also reason to believe Axii can momentarily weaken their drive to kill and somewhat weaken these fierce foes. The Hounds' icy nature also means they can " +
                        "draw strength from extreme cold. Thus one should be particularly on guard when fighting them during blizzards or in glacial regions. Elven legends likewise claim " +
                        "they gain strength when a red moon - a known herald of the Hunt's arrival - hangs in the sky"
                        , "Monster Bone, Monster Brain, Monster Saliva, Rotting Flesh, and Sulfur"
                        , "Always Together with Wild Hunt"
                        , "Dimeritium Bomb, Elementa Oil, Igni, and Axii"
                        , "Assets\\hunt.png");

                    //THE APIARIAN PHANTOM
                    Elementa[5] = new Entry(
                        "The Apiarian Phantom"
                        , "The \"Apiarian Phantom\" destroying the Meiersdorf family's hives turned out to be a lost Hound of the Wild Hunt. When fighting such a beast, one must bear in mind " +
                        "three things. First of all, that the thick armor of ice covering it can only be pierced by strong blows. Second, that, like any other frost-born creature, it is " +
                        "vulnerable to fire, the Igni Sign included. Third and last: that it shall show no mercy."
                        , "Wild Hunt Hound Trophy, and Sulfur"
                        , "In hut near Honeyfill Meadworks"
                        , "Dimeritium Bomb, Elementa Oil, Igni, and Axii"
                        , "Assets\\apiarian.png");

                    //FIRE ELEMENTAL
                    Elementa[6] = new Entry(
                        "Fire Elemental"
                        , "Fire is the most destructive of the elements, thus the aggressive lethality of the creature that embodies its essence should come as no surprise. Fire elementals are " +
                        "forged in complicated magic rituals for one purpose: destruction. And they pursue this with murderous determination. This elemental attacks using fireballs and streams " +
                        "of flame which reduce anything in their path to ashes in the blink of an eye.Like golems and other elementals, poison does not touch it nor does it bleed.Fire - based " +
                        "spells not only do no harm but in fact strengthen it - thus one should by no means think of striking it with Igni.Though vulnerable to silver blades, getting within " +
                        "sword's reach of one is dangerous due to the furnace-like heart they emanate. When fighting a fire elemental one should thus strike from a distance, using frost-spewing " +
                        "and dimeritium bombs, for they will do it the most damage."
                        , "Greater Dazhbog Runestone"
                        , "Found in magical ruins"
                        , "Dimeritium Bomb, Northern Wind, Elementa Oil, and Aard"
                        , "Assets\\fire.png");

                    //ICE ELEMENTAL
                    Elementa[7] = new Entry(
                        "Ice Elemental"
                        , "An ice elemental is a mass of frozen water animated by magic. Deprived of consciousness or independent will, this elemental is boundlessly obedient to the orders of the " +
                        "mage who created it. Those orders usually contain but one syllable: kill. Ice elementals have no qualms about carrying out this order nor any particular difficulty in doing " +
                        "so. Gifted with incredible strength, they are completely invulnerable to poison and fire, deprived of sensitive organs, hard as permafrost and all in all incredibly difficult " +
                        "opponents.A witcher's only chance at tipping the scales towards victory is to toss a dimeritium bomb – shrapnel made of this metal interferes with the workings of the spell " +
                        "that gives this creature life. Beyond that remains only prayer."
                        , "Elemental Essence"
                        , "Skellige"
                        , "Dimeritium Bomb, and Elementa Oil"
                        , "Assets\\ice.png");

                    //THERAZANE
                    Elementa[8] = new Entry(
                        "Therazane"
                        , "There's no such thing as a risk-free real estate investment. It might turn out your new home has a leaky roof, structural rot in the attic, a scratched floor in the living " +
                        "room... or elven ruins beneath its foundations, and within them an enormous earth elemental just waiting for a chance to break free of its chains. Fighting such a monster is no " +
                        "easy task.Its tough outer husk deflects all but the strongest blows.It can liquefy a man's bones with one crushing blow from its fists - thus, one should never near it without " +
                        "first casting the Quen Sign. One should have the Yrden Sign at the ready as well, whereas the other signs - Igni, Aard and Axii - are completely ineffective against it."
                        , "Earth Elemental Trophy, Earth Elemental Mutagen, Clever Hood, Monster Claw, Powdered Monster Tissue, Monster Eye, and Fifth Essence"
                        , "Moldavie Residence"
                        , "Dimeritium Bomb, and Elementa Oil"
                        , "Assets\\Therazane.png");

                    //GARGOYLES
                    Elementa[9] = new Entry(
                        "Gargoyles"
                        , "Gargoyles are stone statues brought to life by magic in order to guard mages' laboratories and lairs from intruders. Their appearance alone has scared off more than one " +
                        "prospective burglar. Those who do not take fright at the sight of these horned and winged monstrosities usually die shortly thereafter, torn to shreds by stony claws."
                        , "Gargoyle Dust, Gargoyle Heart, Elemental Essence, Iron Ore, and Monster Heart"
                        , "Abandoned Ruins and Castles"
                        , "Dimeritium Bomb, Elementa Oil, and Quen"
                        , "Assets\\gargo.png");

                    //MOREAU'S GOLEM
                    Elementa[10] = new Entry(
                        "Moreau's Golem"
                        , "Long years of solitary study tend to make mages somewhat eccentric. As the years pass, laypeople being to irritate them more and more: they are dense, unreliable, " +
                        "disobedient and determined not to understand the gravity of mages' work. They display emotion when they should show discipline and self-mastery. No wonder mages have " +
                        "long considered the best companions to be artificial constructs they themselves bring to life and design to follow their orders and meet their needs. Professor Moreau " +
                        "was no exception in this regard. His golem was his dutiful servant and companion, in good times and bad. Moreau's golem was also an excellent guardian: massive, unyielding " +
                        "and devilishly strong. All in all, he was a tough nut for a witcher to crack!"
                        , null
                        , "Mont Crane Castle"
                        , "Dimeritium Bomb, and Elementa Oil"
                        , "Assets\\moreau.png");
                }

                /*--------------Hybrds-----------------------
                                   
                Click To Expand*/{

                    //EKHIDNA
                    Hybrids[0] = new Entry(
                        "Ekhidna"
                        , "They are a larger, stronger, breed of sirens. They make bodies of water a dangerous place."
                        , "Ekhidna Mutagen, Lock of Lamia Hair, Monster Brain, Monster Blood, Monster Bone, Monster Claw, Monster Ear, Monster Eye, Monster Heart, Monster Liver" +
                        "Monster Tongue, Monster Tooth, Sea Shell, and Water Essence"
                        , "Bodies of water and Shorelines"
                        , "Grapeshot, Hybrid Oil, Igni, and Aard"
                        , "Assets\\ekhidna.jpg") ;

                    //HARPY
                    Hybrids[1] = new Entry(
                        "Harpy"
                        , "It is hard to say what is most repulsive about harpies and their cousins, the shishigas: their hideous appearance, the overwhelming stench of rot and bird " +
                        "excrement that clings to them or their bloodcurdling screech. Suffice it to say that even rats, who dwell happily among the rankest fecal matter and rotten waste, " +
                        "give their nests wide berth. Harpy nests are most often found atop high cliffs or rocky ravines. Sure signs of having strayed near one are crumbling human and " +
                        "animals remains, guano-streaked rocks and feathers littering the ground. Harpies and shishigas hunt in flocks consisting of a handful to up to twenty individuals. " +
                        "Though rather cowardly and cautious, harpies fiercely defend their nests and will not hesitate to attack when outnumbering their foes. During combat they use their " +
                        "ability to fly to dive swiftly to strike their victims one by one before soaring back up out of reach. They can kill with their wings or their sharp beak and talons. " +
                        "Once on the ground they move slowly and clumsily, and thus no longer present much of a threat."
                        , "Harpy Egg, Harpy Talons, Harpy Feathers, Lesser Blue Mutagen, Monster Liver, and Raw Meat"
                        , "Highlands"
                        , "Grapeshot, Hybrid Oil, and Aard"
                        , "Assets\\Harpy.png");

                    //SALMA
                    Hybrids[2] = new Entry(
                        "Salma"
                        , "The witcher's investigation uncovered that a succubus named Salma was responsible for the string of killings afflicting the Novigrad city guard. This came as a " +
                        "surprise, for succubi do not usually commit premeditated, cold-blooded murder. This is not to say they are not dangerous: they will at times kill on accident, when " +
                        "carried away on a particularly gushing stream of ecstasy. At other times, they kill in self-defense: though they have the look of slender maids from the waist up, their " +
                        "supple limbs hide incredible strength. They are also invulnerable to fire, the Igni Sign included. They present witchers with an intractable dilemma: does this monster, " +
                        "who wishes me no ill yet all the same often causes harm, deserve death, or mercy?"
                        , null
                        , "Novigrad"
                        , "Hybrid Oil, and Quen"
                        , "Assets\\salma.png");

                    //ERYNIAS
                    Hybrids[3] = new Entry(
                        "Erynias"
                        , "Hard as it is to imagine, the erynias found in Skellige are even more repulsive - and dangerous - than harpies, their close relatives. Though well-rotten carrion is " +
                        "their food of choice, they will not turn up their noses at fresh meat, man flesh included. When they spy a potential victim, erynias, like harpies or shishigas, will " +
                        "try to make full use of the strength of their numbers and their ability to control the skies.They will circle above their prey then attack from several directions at once, " +
                        "striking with razor - shark talons and tearing their targets to shreds. While attacking they aim for the neck, eyes and other vital organs, often causing their prey " +
                        "to bleed to death as a result.In this way a small flock of erynias is able to make quick work of larger and better - armed victims, who often are not able to defend " +
                        "themselves effectively from several opponents attacking at once."
                        , "Erynia Eye, Monster Blood, and Monster Feather"
                        , "Skellige"
                        , "Grapeshot, Hybrid Oil, and Aard"
                        , "Assets\\Erynias.png");

                    //MELUSINE
                    Hybrids[4] = new Entry(
                        "Melusine"
                        , "In the mountains near the village of Svorlag in Skellige lies an enormous complex of caves. For many centuries they were given wide berth on account of the " +
                        "bloodthirsty ekhidna known as Melusine who had made them into her lair. Melusine was a beast so powerful some islanders worshiped her as a semi - divine being.The " +
                        "witcher, however, harbored no such delusions.He knew she was an extremely powerful monster - but a monster all the same.This meant she could be killed.To do so, he " +
                        "would need the highest quality bolts, a solid silver blade -and a steady hand."
                        , "Ekhidna Mutagen, Ekhidna Trophy, and Lock of Lamia Hair"
                        ,"Spikeroog"
                        ,"Grapeshot, Hybrid Oil, Igni, and Aard"
                        ,"Assets\\Melusine.png");

                    //SIREN
                    Hybrids[5] = new Entry(
                        "Siren"
                        , "Like skilled hunters setting out wooden ducks to lure in drakes, sirens and lamias lure men near - using their own bodies as decoys. They can transform to resemble " +
                        "beautiful human maidens, though with tails covered in silver scales instead of legs. Once a naive sailor gets within arm's reach of these beautiful creatures, their " +
                        "fair faces suddenly turn to fang-filled, fish-like maws, and lovely tails promising unknown delights become sharp, death dealing talons. One legend claims sirens and " +
                        "lamias were once friendly towards men – and supposedly were even known(albeit on rare occasions) to accept some sailors' clumsy attempts at courtship. In our day, however, " +
                        "they are decidedly aggressive, perhaps soured by the numerous kidnappings of carried out by frustrated sea salts. Whatever the truth, one thing is certain: these days " +
                        "the monsters display no signs of good will, and so when spotting them one should immediately reach for one's silver sword."
                        , "Monster Tooth, Siren Vocal Cords, and Water Essence"
                        , "Coastal Regions throughout Velen and Novigrad, Skellige is also a major breeding ground."
                        , "Grapeshot, Hybrid Oil, Igni, and Aard"
                        , "Assets\\Siren.png");

                    //GRIFFIN
                    Hybrids[6] = new Entry(
                        "Griffin"
                        , "Griffins were once only found high in the mountains, where they would hunt marmots and wild goats. When humans encroached on their lands, however, griffins soon discovered " +
                        "a new source of much more plentiful and easier-caught prey: cows, sheep and shepherds. Though still wary of main roads and towns (where folk with the means to hire a witcher " +
                        "are like to dwell), these half-eagle, half-wildcat creatures have gone from rarities to oft-encountered pests known throughout the Northern Realms. Especially hated are the " +
                        "subspecies known as royal griffins and archgriffins. Griffins mate for life and when their partner is attacked they will defend it to the death.For this reason they are often " +
                        "considered the embodiment of courage, loyalty and fighting spirit.This last attribute no one would deny them – when provoked, they will not cease their attack until they have " +
                        "torn their opponent to shreds. Griffins find their victims using their extraordinary perceptive sense of smell. After drawing near to their chosen target they attack by swooping " +
                        "down from great height.Their muscular mass combined with their swift speed mean his blow alone is often enough to end the fight. If, however, the victim survives this aerial " +
                        "assault, the griffin will immediately engage it in direct combat, making use of its sharp, curved beak and powerful talons. The wounds it deals are deep and cause powerful " +
                        "bleeding.Even worse, griffins do not have any true weaknesses – except for their vulnerability to hybrid oil and certain kinds of bombs."
                        , "Griffin's Egg, Griffin Feathers, Griffin Mutagen, Griffin Trophy, Infused Dust, Monster Brain, Monster Claw, Monster Eye, Monster Heart, and Raw Meat"
                        , "Ovenfurt, Skellige, Velen, and White Orchard"
                        , "Grapeshot, Hybrid Oil, and Aard"
                        , "Assets\\Griffin.png");

                    //OPINICUS
                    Hybrids[7] = new Entry(
                        "Opinicus"
                        , "Killers of various stripes - mercenaries, knights errant, ambitious lawmen - try at times to compete with witchers as monster slayers. This usually ends in a massacre that not " +
                        "only does not solve the problem, but in fact only makes it worse - the beast walks away from the fight unharmed, enraged and out for vengeance. Such was the case in the mountains " +
                        "outside Oxenfurt, where a powerful archgriffin had made its nest. Once again it fell to the witcher to clean up after amateurs.He knew neither Igni nor bombs dealing fire damage " +
                        "would have any effect against this fire - loving creature.He would also have to look out for its acid, which can eat through even the thickest armor - leaving one vulnerable to " +
                        "its razor - sharp talons."
                        , "Arhgriffin Mutagen, Griffin's Egg, Griffin Feathers, Griffin Trophy, Monster Brain, Monster Tongue, and Zireael Armor"
                        , "Forest Outside Oxenfurt"
                        , "Grapeshot, Hybrid Oil, and Aard"
                        , "Assets\\Opinicus.png");

                    //SUCCUBUS
                    Hybrids[8] = new Entry(
                        "Succubus"
                        , "Unlike other monsters, succubi and menads feel no desire to kill, do not crave human blood and usually do not, in fact, mean any harm at all. They are motivated by one thing and " +
                        "one thing only: an insatiable lust. They try in vain to slake this by engaging in sexual acts with any other humanoid species they encounter. While it must be admitted that their \"victims\"" +
                        " rarely put up much resistance, this does not mean succubi and menads do not present any danger: their never-ending advances, though pleasurable at first, have pushed more than one man " +
                        "to madness or even death. Succubi and menads usually can be found near human settlement, including small villages and populous cities.They prowl at night, though when stricken by serious " +
                        "need they will leave their lairs during the day as well.They shower their affections on men as well as women, the young as well as the old, the ugly as well as the beautiful.Some of them " +
                        "are particularly fond of pastors and other holy men, whose seduction they treat as a sort of game. Though succubi are peaceful by nature, when forced to fight they will defend themselves " +
                        "fiercely.One should thus not be fooled by their fair appearance – under the velvety skin of their arms lie muscles of iron, and a blow delivered with their rear, goat - like legs or the " +
                        "thick horns on their head can easily crush bone."
                        , "Succubus Mutagen"
                        , "Try to live close to their \"prey\", near towns and villages. Some succubi inhabit cities."
                        , "Hybrid Oil, and Quen"
                        , "Assets\\Succubus.png");



                }

                /*--------------Insectoids-------------------
                 
                Click To Expand*/{

                    //ARACHASAE
                    Insectoids[0] = new Entry(
                        "Arachasae"
                        , "Powerful pincers, a maw filled with razor-sharp teeth and venom glands packed with deadly toxins – these creatures constitute the arachas' deadly arsenal. " +
                        "Since people and farm animals make up an important part of these creatures' diet, contracts on arachasae in turn constitute an important source of witcher " +
                        "coin. Once native to the far south, this invasive species migrated north over the course of decades, adjusting as it went to new climates and temperatures.It " +
                        "found damp woodlands and swamps most hospitable and made them its home, making use of the much and moss found there as blankets during its winter hiberation. The " +
                        "arachas hides its unprotected, sack - like abdomen under a covering of hollow tree - trunks worn on its back. At first glance, a stationary arachas often looks " +
                        "like a part of the forest undergrowth, a fact it uses to deadly advantage when hunting.It usually begins a battle by spitting venom, then tries to grab its prey" +
                        " with prehensile feelers in order to drag it within reach of its crushing pincers."
                        , "Arachas Eyes, Chitinous Shell, Arachas Venom, and Lesser Red Mutagen"
                        , null
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\arachasae.png");

                    //ARACHNOMORPHS
                    Insectoids[1] = new Entry(
                        "Arachnomorphss"
                        , "A similar saying could gain ground in our land concerning arachnomorphs and everything unable to flee them – meaning most every creature in the world. True, the " +
                        "tillers of the earth and fellers of trees need not fear them in their daily labors, for arachnomorphs, as distant, post-Conjunction cousins of common spiders, " +
                        "strongly prefer deep, dark caves and unfrequented sodden swamps. Anyone who does come across them, however, had best hope his conscience is clear and his worldly " +
                        "affairs are in order, for his life shall soon end, as not even the fastest man in the world can outrun them and only a few witchers can hope to slay them. Even " +
                        "worse are the more aggressive and dangerous kind known as arachnomorph colossi, which are capable of devouring an entire ox in seconds."
                        , "Chitinous Shell, Lesser Blue Mutagen, Lesser Green Mutagen, Monster Blood, Monster Hair, Monster Heart, Monster Saliva, Monster Tooth, and Venom Extract"
                        , null
                        , "Aard, Axii, and Insectoid Oil"
                        , "Assets\\arachonomorphs.png");

                    //ARMORED ARACHASAE
                    Insectoids[2] = new Entry(
                        "Armored Arachasae"
                        , "An arachas' only weakness is its soft, sensitive abdomen. Some arachasae hide this under hollow tree stumps, while other, \"armored\" varieties exist which have grown " +
                        "a thick carapace that covers all the more delicate parts of their bodies. An armored arachas is a true behemoth.It uses its enormous mass to knock over and trample its " +
                        "victims then devours their crushed remains.Like all arachasae, it is highly venomous, and this Golden Oriole should always be consumed before fighting it. It is also " +
                        "worthwhile to stock up on healing potions and crossbow bolts before setting out, for this arachas' thick plating can withstand a great deal of damage, making battles " +
                        "with it a long and exhausting affair."
                        , "Arachas Eyes, Chitinous Shell, and Arachas Venom"
                        , "Novigrad, and Skellige"
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\ArmoredAra.png");

                    //ENDREGA DRONES
                    Insectoids[3] = new Entry(
                        "Endrega Drones"
                        , "Endrega males – called 'drones' – are gluttonous creatures whose only aim in life is to eat, fight and reproduce. Yet when venturing outside their nests, these aggressive " +
                        "hunters attack any and every creature they come across. Endrega drones live but brief lives, the culmination of which comes in the autumn when they fertilize the queen.They " +
                        "pass the time leading to that moment protecting the colony's territory. Weaker drones die in these battles, while the largest and strongest survive. These elect ndividuals' " +
                        "genes are passed down to the next generation of endregas, while they themselves are killed after fertilization takes place and their bodies used to feed the hive during the " +
                        "long winter months. Drones are easy to identify thanks to their distinctive, cone - shaped abdomens.Unlike other endregas they can attack from a distance, sending out volleys " +
                        "of poisoned quills. As with all of their kind, bleeding has no effect on them and insectoid oil does them great harm."
                        , "Chitinous Shell, Endrega Armor Plates, and Lesser Red Mutagen"
                        , "Novigrad, Skellige, and Toussaint"
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\drones.png");

                    //ENDREGA WARRIORS
                    Insectoids[4] = new Entry(
                        "Endrega Warriors"
                        , "Endless waves of endrega workers are enough to overcome most attackers, but when confronting more dangerous foes, endrega colonies unleash their larger, stronger members – " +
                        "the so-called warriors. This caste lives only to fight, and gets ample opportunity to do so while defending the colony's borders or conquering new territory. An endrega warrior's " +
                        "main weapon is its long tail, which is tipped with a club-like growth and spiked with venomous quils. Powerful abdominal muscles allow it to swing this tail with enough force " +
                        "to kill most lesser opponents in one blow. Endrega warriors also use their mass and strength as a weapon by charging their opponents in an attempted to knock them over. As " +
                        "invertebrates with sectioned carapaces, endrega warriors do not bleed profusely, yet recoil in great pain when hit with a blade coated in insectoid oil."
                        , "Chitinous Shell, Endrega Armor Plates, Endrega Heart, Lesser Blue Mutagen, Lesser Green Mutagen, and Venom Extract"
                        , "Velen, and Skellige"
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\warrior.png");

                    //ENDREGA WORKERS
                    Insectoids[5] = new Entry(
                        "Endrega Workers"
                        , "Workers are the most numerous, and thus the most frequently encountered, caste of endrega. Within the colony their duty lies in building nests and cocoons, acquiring food and " +
                        "caring for eggs and larvae. When threatened they will summon warriors to aid them, yet if forced to defend themselves they will – and do so surprisingly well. Endrega workers " +
                        "are most often found traveling in groups of half - dozen or more members.They move slowly, yet when attacking, they are capable of covering the distance to their victim in the " +
                        "blink of an eye.Like all of their kind, endrega workers are highly venomous.Their bite is toxic, as are any wounds dealt by the bony growths on the ends of their limbs.They can " +
                        "also spew acid to great effect from a distance of several paces.Their usual tactic is to surround their enemy and attack him from several sides at once.Like all insectoids they " +
                        "do not suffer particularly from bleeding, yet are caused great harm by insectoid oil."
                        , "Venom Extract, Endrega Embryo, Endrega Heart, Lesser Blue Mutagen, Lesser Green Mutagen, Chitinous Shell, and Monster Saliva"
                        , "Velen, and Skellige"
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\worker.png");

                    //GIANT CENTIPEDES
                    Insectoids[6] = new Entry(
                        "Giant Centipede"
                        , "Giant centipedes are enormous, insect-like monsters which can be found in many places in the world, but are particularly common in the lands (or more precisely, under the lands) of " +
                        "Toussaint. There they often dwell in close comity with shaelmaars, for a sort of monstrous symbiosis has developed between them: giant centipedes feed on the small creatures which eat " +
                        "Shaelmaar dung. Hard chitinous armor covers nearly the entire body of a giant centipede.Sticking out from under this carapace are rows of hooked limbs.Giant centipedes are able to burrow " +
                        "into the ground with shocking speed, only to then appear back on the surface in another place.Once they select a target, they will circle it determinedly, trying to get close enough to " +
                        "deliver a blow.They attack primarily with their powerful mandibles, but they also possess glands allowing them to spew acid. The greatest obstacle when fighting giant centipedes is their " +
                        "thick armor, which deflects most blows not only from weapons, but also from magical means – such as those dealt by simple spells or witcher Signs. When attacked with a weapon, they will " +
                        "often parry the strike, then quickly reply with their own forceful counter.Thus the best method for fighting them is to chatch them in an Yrden trap, keeping them from protecting themselves " +
                        "with their armor or burrowing into the ground."
                        , "Giant Centipede Discharge, Giant Centipede Mandible, and Monster Blood"
                        , "Toussaint"
                        , "Insectoid Oil, and Yrden"
                        , "Assets\\GiantCentipede.png");

                    //HARRISI
                    Insectoids[7] = new Entry(
                        "Harrisi"
                        , "Velen's woods and bogs brim with monsters. This fact is well known, and thus when the war drove refugees into this hostile land, certain of their number thought to avoid the dangers of the " +
                        "lowlands by hiding in an abandoned mine. They were in for an unfortunate surprise. The shaft they chose for their sanctuary was inhabited by a poisonous arachas - a merciless and bloodthirsty " +
                        "monster. The witcher knew he was in for a tough fight.The arachas had dwelled in the mine for years and had grown large and particularly strong and resilient in that time.Like other members of " +
                        "its vile species, it would be dangerous both at close quarters and at a distance.What's more, it was almost certainly venomous - he would need to imbibe Swallow or Golden Oriole (or both) before " +
                        "attacking if he was to stand a chance of surviving. As a small consolation, the witcher knew the monster would be vulnerable to his Signs - especially Igni, Aard and Yrden - as well as to the " +
                        "Northern Wind bomb. The witcher arrived at the cave too late to save the refugees - but he could still avenge their fate.He slew the powerful arachas and destroyed the eggs bearing its vile offspring."
                        , "Chitinous Shell, Arachas Eyes, Arachas Mutagen, Arachas Trophy, Arachas Venom, Rotting Flesh, and Mahakaman Trousers"
                        , null
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\Harrisi.png");

                    //KIKIMORE WARRIOR
                    Insectoids[8] = new Entry(
                        "Kikimore Warrior"
                        , "It is unknown how exactly it is kikimores communicate with each other. Autopsies are hampered by the high toxicity of their subjects. Scholars have established that kikimores do not seem to possess " +
                        "any detectable auricles. One amateur researcher, Count di Salvaress, put forth a theory in his treatise \"A Microscope Among Monsters\" suggesting kikimores have a highly developed since of smell and use " +
                        "airborne particles undetectable to humans to transmit information. This theory has yet to be proved or disproved. Kikimore warriors defend their nests from attackers.They attack somewhat slower than kikimore" +
                        " workers.They are able to spew streams of caustic venom a great distance and leap to attack.This venom is highly unique in that it reacts with a witcher's body to raise the level of his potion toxicity. " +
                        "They are covered with thick, hard armor which easily deflects blows from even the sharpest sword. Kikimore warriors are protected by swarms of workers which obey their orders until they are themselves" +
                        " eradicated. They are completely immune to the effects of the Axii Sign, but vulnerable to Igni, oils and bombs harming insectoids and blows dealt by a silver sword."
                        , "Kikimore Discharge"
                        , "Toussaint"
                        , "Insectoid Oil, White Honey, and Igni"
                        , "Assets\\kikiWa.png");

                    //KIKIMORE WORKER
                    Insectoids[9] = new Entry(
                        "Kikimore Worker"
                        , "Kikimores form colonies, making them similar to communal insects such as ants. A kikimore colony is ruled by a queen and organized into something of a social hierarchy. Kikimore workers take care of " +
                        "hunting food and bringing it back to the nest, while kikimore warriors defend the nest against attackers. A worker on its own can be easily killed by even a weak person or a child.It is rare indeed, however, " +
                        "to come across an isolated individual, for kikimore workers usual move in groups of a few to a dozen or so members.The only defense against a swarm of kikimores available to a normal person is to flee. " +
                        "And not even that is guaranteed to work. Kikimore workers listen to orders given by kikimore warriors.On command, a swarm of workers might begin burrowing tunnels near potential prey to allow for a surprise " +
                        "mass attack.Eliminate the warrior guiding a swarm, however, and the workers will disperse and cease digging. Kikimore workers are nimbler and quicker than warrriors. They show complete immunity to the " +
                        "Axii Sign, and when they dig tunnels, they are invulnerable to all the other Signs as well.Poison also does them no harm. A good method for fighting them is to use the Igni Sign as well as oils and bombs " +
                        "meant to damage insectoids."
                        , "Kikimore Discharge"
                        , "Toussaint"
                        , "Insectoid Oil, White Honey, and Igni"
                        , "Assets\\kikiWo.png");

                    //PALE WIDOWS
                    Insectoids[10] = new Entry(
                        "Pale Widows"
                        , "This rare variety of giant centipede dwells in underground lairs and owes its name to its unusual, pale white coloring. Like the more common giant centipede, its body is covered in hard chitinous armor, " +
                        "with numerous hooked limbs sticking out from underneath. Some scholars raise these creatures in laboratory conditions for the properties of their albumen, which makes an excellent base for the brewing " +
                        "of mutagenic potions."
                        , "Chitinous Shell, Giant Centipede Discharge, Giant Centipede Mandible, Monster Carapace, Monster Stomach, Red Mutagen, and Greater Red Mutagen"
                        , "Toussaint"
                        , "Insectoid Oil, and Yrden"
                        , "Assets\\PaleWidow.png");

                    //SANDCRABS
                    Insectoids[11] = new Entry(
                        "Sandcrabs"
                        , "Sandcrabs have well-developed carapaces, and two pairs of legs and a pair of wings, even though it is unknown whether the creatures are able to fly. A most eye-catching feature is the very long horn on " +
                        "their heads."
                        , "Sulfur, Rotting Flesh, Monster Blood, Monster Bone, Monster Saliva, and Monster Brain"
                        , "Ddiddiwedht Desert"
                        , "Samum, Northern Wind, Dancing Star, and Grapeshot"
                        , "Assets\\sandcrab.jpg");

                    //VENOMOUS ARACHASAE
                    Insectoids[12] = new Entry(
                        "Venomous Arachasae"
                        , "Though all arachasae are highly venomous, this breed produces an especially strong toxin. A few drops are enough to kill a grown man – unless that man is a witcher, whose mutations will neutralize small " +
                        "amounts of this venom. Large quantities, however, will kill anything they touch, with mutations only prolonging an inevitable and painful death in such instances. Venomous arachasae produce colossal amounts " +
                        "of this toxin and deploy it during combat in many ways.Before striking a venomous arachas will cover its pincers and teeth with a thick coating of the deadly liquid.It will then squirt the venom at its opponent " +
                        "to weaken it, and once locked in direct combat, will continue spraying the noxious ooze all around itself, meaning every breath brings its victim closer to death.Like other members of this species, venomous " +
                        "arachasae use prehensile feelers to grab and immobilize their prey.When attempting to fight such a creature a witcher should drink Golden Oriole, which will reduce his body's vulnerability to poison, and then " +
                        "attack from a safe distance with crossbow or bombs before dealing the finishing blows with a silver sword enhanced with a coating of insectoid oil."
                        , "Arachas Eyes, Chitinous Shell, and Arachas Venom"
                        , "Novigrad, and Skellige"
                        , "Golden Oriole, and Insectoid Oil"
                        , "Assets\\venochasae.png");

                }

                /*--------------Necrophages------------------
                 
                Click To Expand*/{

                    //ABAYA
                    Necrophages[0] = new Entry(
                        "Abaya"
                        , "The bay below Kaer Trolde had a pernicious reputation. At times fishermen who chose to cast their nets in its waters would never come home again. " +
                        "Something would drag oarsmen off their longships or knock the ships themselves over. The locals blamed this on sea devils - the Skelligers' " +
                        "name for drowners. The truth, however, proved far worse. A water hag had made her lair in the caves beneath the cliffs of Kjerag.An old and " +
                        "experienced water hag.With powerful claws able to demolish any attempt to block or parry.And the ability to blind opponents from a distance, " +
                        "then strike with a lightning - quick counterattack.Signs would be needed to best her - Yrden, to slow her, and Quen, to protect from her blows. " +
                        "Needed most of all, however, would be a great deal of luck. The witcher, though, never was one to count on luck alone.Instead, he pulled a few " +
                        "tricks from up his sleeve to even the odds.By masking his scent, he managed to catch the monster by surprise... and slay it."
                        , "Water Hag Mutagen, Water Hag Tooth, and Water Hag Trophy"
                        , "Underwater cave off Kaer Trolde Harbor"
                        , "Northern Wind, Necrophage Oil, Quen, and Igni"
                        , "Assets\\abaya.png");

                    //ALGHOUL
                    Necrophages[1] = new Entry(
                        "Elghoul"
                        , "Alghouls differ from normal ghouls in size, strength, coloring and, most importantly, intelligence. Whereas ghouls and graveirs are primitive " +
                        "creatures unfit to plan even the simplest ambush, alghouls and their kindred (such as cemetaurs) are capable of forethought, and are thus much " +
                        "more dangerous. Ghouls seem to possess wits enough to at least know a brighter mind when they see it, and so let alghouls and cemetaurs lead their " +
                        "packs.A pack so led will terrorize all in its path, attacking not only lone travelers but also caravans and even farmsteads.When encountering such " +
                        "a pack the alghoul should be eliminated as a first priority, leaving the other beasts for once their leader is gone.One be particularly careful " +
                        "when fighting alghouls around dusk and at night, when they fight with doubled strength. During combat alghouls and cemetaurs try risky maneuvers " +
                        "aimed at knocking their opponents to the ground so the others can finish the job by tearing them to shreds. Like a normal ghoul, an injured alghoul " +
                        "can fall into a frenzy and attack with blind fury. An experienced witcher knows to get out of its way on such occasions and strike from behind, " +
                        "while for an inexperienced witcher, such a turn of events often marks the end of his Path."
                        , "Alghoul Bone Marrow, Alghoul Claw, and Alghoul Mutagen"
                        , "Battlefields and any location where a large number of corpses can be found in shallow graves or left out to rot."
                        , "Necrophage Oil, and Axii"
                        , "Assets\\alghoul.png");

                    //DEVOURER
                    Necrophages[2] = new Entry(
                        "Devourer"
                        , "evourers are often called night witches, because they resemble old, ugly women and are famous for their witch-like viciousness. These creatures " +
                        "gorge themselves on human flesh; although they willingly eat carcasses, above all they crave flesh that is fresh and warm. Devourers hunt after dark " +
                        "in groups that peasants refer to as sabbaths. They like to deceive their victims and torture them, but there is no truth to the tales of their midnight " +
                        "flights on broomsticks and their gingerbread houses."
                        , "Devourer's Blood, Necrophage Hide, Rotfiend Blood, Monster Brain, Monster Bone, Monster Heart, Monster Liver, Monster Saliva, Monster Tongue, and Monster Tooth"
                        , "With rotfiends, near corpses"
                        , "Necrophage Oil"
                        , "Assets\\devourer.png");

                    //DROWNER
                    Necrophages[3] = new Entry(
                        "Drowners"
                        , "A drowner resembles a corpse dredged from the bottom of a pond. It is sickly blue or green in color, with slime and sludge oozing out of every pore and the " +
                        "acrid stench of rot wafting off of it. That is why it is often thought drowners - along with their more dangerous cousins: vodniks, mucknixers and drowned " +
                        "dead – arise from the bodies of those who drown in shallow water: lost travelers falling into bogs, children who swim too far from the shore or, in the " +
                        "case of vodniks, inebriated peasants who stumble off narrow swamp trails. Like so many other beliefs about monsters, this one is false.While drowners do " +
                        "look like humans from a distance, witchers, who have the dubious pleasure of examining them from close quarters, have reported the numerous ways in which " +
                        "their anatomy differs from our own.Their scaly skin, gills and dorsal fins suggest drowners and their like are an entirely foreign species. The adaptations " +
                        "mentioned below make drowners excellent swimmers, well-suited to the muddy waters of the ponds and lakes in which they dwell.They often cluster near human " +
                        "settlements, which are for them an excellent source of food. Cowardly creatures by nature, they usually stick to eating scraps they dig out of rubbish piles " +
                        "and animal carcasses.Yet if a lone traveler or careless fisherman strays into their territory, they turn from scavengers to fearsome predators.They can attack " +
                        "with lightning speed, taking their victim by surprise and pulling him into the water to drown. If not particularly hungry at the moment, they will keep their " +
                        "prey under the water for a few days, aging it until it grows deliciously tender and rotten.Drowners are particularly active at dusk and during the night, " +
                        "especially if the rain is falling – at such times they will even leave their watery homes and venture inland."
                        , "Drowner Brain, Drowner Tongue, Monster Blood, Monster Heart, Monster Hair, Monster Saliva, Monster Tooth, and Water Essence"
                        , "Novigrad, Skellige, Toussaint, Velen, and White Orchard"
                        , "Necrophage Oil, and Igni"
                        , "Assets\\drowner.png");

                    //DROWNED DEAD
                    Necrophages[4] = new Entry(
                        "Drowned Dead"
                        , "Particularly strong and dangerous drowners are known as the drowned dead. Simple people see no difference between the drowner and the drowned dead – encountering " +
                        "either of them is equally deadly. We might suppose, though, that the most gloomy legends concern the drowned dead rather than drowners."
                        , null
                        , "Kaer Morhen Valley, Novigrad, Skellige, and Velen"
                        , null
                        , "Assets\\Drowdead.png");

                    //FOGLET
                    Necrophages[5] = new Entry(
                        "Foglet"
                        , "Fog is the traveler's foe. In the forest, it can make one lose one's way, at sea, it can send one sailing into the rocks. Yet such dangers are nothing compared to" +
                        " the monsters known as foglets which sometimes lurk within it. These creatures have powerful arms and claws like Zerrikanian kinjals, yet what makes them truly " +
                        "dangerous is their mastery of deception, beguilement and disorientation. Many times they need not attack at all, instead simply driving their prey to madness or into" +
                        " boggy marshlands, after which they wait patiently for it to drown in the muddy waters."
                        , "Foglet Teeth, Foglet Mutagen, and Lesser Blue Mutagen."
                        , "Isle of Mists, Kaer Morhen, and Velen"
                        , "Moon Dust, Necrophage Oil, and Quen"
                        , "Assets\\foglet.png");

                    //GHOUL
                    Necrophages[6] = new Entry(
                        "Ghoul"
                        , "Ghouls and graveirs are hard to describe. In part, they resemble humans - yet on the whole, they are the utter negation of all that is human. Though they have arms " +
                        "and legs like men, they walk on all fours like dogs or badgers. Though they have eerily familiar faces, one searches them in vain for any sign of sentiment, reason or " +
                        "even a spark of consciousness. They are driven by one thing and one thing only: an insatiable craving for human flesh. Ghouls and their more dangerous cousins, graveirs," +
                        " usually feed in small groups, at times led by an alghoul.Since they delight most in the taste of fresh carcasses, they appear wherever newly - dug graves are to be " +
                        "found: cemeteries, crypts, catacombs and battlefields.Whenever the opportunity arises they hunt the living as well, especially when they have strength in numbers. In a " +
                        "one - on - one fight with a trained witcher, a ghoul poses little threat, but one must remember that wounded individuals can erupt in a mad frenzy.At such times they " +
                        "attack fiercely, paying no heed to their own safety and brushing off all wounds.One must likewise bear in mind that ghouls and graveirs are particular dangerous around " +
                        "dusk and at night."
                        , "Ghoul's Blood, Monster Blood, Monster Claw, Monster Eye, Monster Liver, Monster Saliva, Monster Tongue, Monster Tooth, and Venom Extract"
                        , "Anywhere near corpses"
                        , "Necrophage Oil"
                        , "Assets\\ghoul.png");

                    //GRAVE HAG
                    Necrophages[7] = new Entry(
                        "Grave Hag"
                        , "Few monsters' names fit as well as the grave hags'. As one might guess, these creatures resemble aged, deformed women and loiter near graveyards and battlefields. Grave " +
                        "hags feed on human corpses and in particular on the rotten marrow which they slurp from human bones using their long, prehensile tongues. Once a hag has devoured all corpses" +
                        " within reach, she turns to killing men and burying them in the cemetery as she waits for them to decompose."
                        , "Grave Hag's Ear, and Grave Hag Mutagen"
                        , "Velen, and Skellige"
                        , "Black Blood, Necrophage Oil, Yrden, and Quen"
                        , "Assets\\Grags.png");

                    //IGNIS FATUUS
                    Necrophages[8] = new Entry(
                        "Ignis Fatuus"
                        , "The monster haunting the peat bogs of Velen turned out to be an ancient foglet. These are exceptionally long-lived creatures - some have even dwelt on this earth for over " +
                        "two hundred years, growing stronger and stronger all the while. Blows dealt by foglets of such an age carry so much power blocking them is out of the question. These foglets " +
                        "possess the ability to move extremely quickly, and not even Yrden can slow them down. Furthermore, they can meld completely into the mist, then suddenly rematerialize to strike " +
                        "from behind. Wearing heavy armor or making good use of the Quen Sign is highly recommended. This ancient foglet proved particularly adept in the art of forming illusions. Only a " +
                        "professional monster slayer skilled with Signs and swords could best such a foe.Luckily, Geralt fit that description."
                        , "Foglet Teeth, Foglet Mutagen, Lesser Blue Mutagen, and Foglet Trophy"
                        , "Cave in Velen"
                        , "Moon Dust, Necrophage Oil, and Quen"
                        , "Assets\\Ignituus.png");

                    //MOURNTART
                    Necrophages[9] = new Entry(
                        "Mourntart"
                        , "Most grave hags rarely attack humans, preferring instead to feed on the rotten remains they dig out of graves. Yet some individuals grow bold over the years and begin sneaking " +
                        "into huts to steal children and kill the elderly. Just such a monster was tormenting the inhabitants of Lindenvale. The witcher knew this grave hag would put up a fierce fight. He " +
                        "would have to watch out for her powerful claws, capable of smashing through any block or parry, and her long, venomous tongue.He also realized her attacks would be so quick not " +
                        "even his mutated reflexes would be able to keep pace - meaning only judicious use of the Yrden Sign would all[sic] him to survive and conquer. The outcome of the fight was not hard " +
                        "to predict. The grave hag perished in the very graveyard which had heretofore served as her feeding grounds, and her body was dumped in a grave she had dug with her own claws."
                        , "Grave Hag Trophy, Grave Hag Mutagen, Grave Hag's Ear, Monster Bone, Monster Claw, Monster Tongue, and Addan Deith"
                        , "Lindenvale"
                        , "Black Blood, Necrophage Oil, Yrden, and Quen"
                        , "Assets\\Mourntart.png");

                    //MUCKNIXER
                    Necrophages[10] = new Entry(
                        "Mucknixer"
                        , "A drowner resembles a corpse dredged from the bottom of a pond. It is sickly blue or green in color, with slime and sludge oozing out of every pore and the acrid stench of rot" +
                        " wafting off of it. That is why it is often thought drowners -along with their more dangerous cousins: vodniks, mucknixers and drowned dead — arise from the bodies of those who " +
                        "drown in shallow water: lost travelers falling into bogs, children who swim too far from the shore or, in the case of vodniks, inebriated peasants who stumble off narrow swamp trails."
                        , "Monster Saliva, Drowner Tongue, and Drowner Brain"
                        , "Swamps and riverbanks in Velen"
                        , "Necrophage Oil and Igni"
                        , "Assets\\mucknixer.png");

                    //ROTFIEND
                    Necrophages[11] = new Entry(
                        "Rotfiend"
                        , "Rotfiends resemble decomposing human bodies that have been stripped of their skin. Their presence is given away by the overwhelming stench of the rot which gives them their name." +
                        " Devourers are a particularly dangerous kind of rotfiend marked by an insatiable appetite for human flesh. Rotfiends and devourers were once rarities, but in the present age of constant " +
                        "warfare and violence they have become a veritable plague, particularly around battlefields and in disease - stricken areas.Though they feed mainly on carrion, they will at times attack " +
                        "the living.They usually feed in large groups and thus present a danger to lone travelers – especially considering their speed, which is more than a match for a horse at full gallop. " +
                        "The rotfiend's decomposing body is filled with gasses which are poisonous even to those who, like witchers, are immune to most other toxins. These emissions are also highly flammable, " +
                        "meaning any spark, not to mention a carelessly-cast Igni sign, can lead to an explosion. This is particularly likely after a rotfiend dies, when its body thrashes around in uncontrollable " +
                        "tremors. Rotfiends and devourers feed in the twilight hours and at night, when they become much more dangerous than during the day."
                        , "Rotfiend Blood, Necrophage Hide, Monster Brain, Monster Bone, Monster Heart, Monster Liver, Monster Saliva, Monster Tongue, and Monster Tooth"
                        , "Velen, White Orchard, Skellige, and Toussaint"
                        , "Necrophage Oil"
                        , "Assets\\rotfiend.png");

                    //SCURVERS
                    Necrophages[12] = new Entry(
                        "Scurvers"
                        , "Scurvers are rotfiends' larger cousins. The bodies of these hideous, vaguely humanoid creatures are covered with rotten scraps of flesh, under which lurk even more rotten muscles stretched " +
                        "around a strong, flexible skeleton. Scurvers, which feed on old, rotting corpses, prefer to make their hunting grounds in abandoned torture sites, forgotten graveyards and old battlefields. " +
                        "They are very aggressive and, though they feed on corpses, if they come across a living person they are likely to attack. Thus when wandering near any of the above-mentioned places, one must " +
                        "be especially cautious. Scurvers usually feed underground, but sometimes, when they catch the scent of a human, they crawl to the surface in a matter of seconds and attack their potential prey." +
                        " While fighting them one cannot afford to forget about their special boney spines, razor - sharp protuberances sticking out from their skeletons.When a scurver is near death, the gasses and " +
                        "enzymes gathered within its body cause it to explode, flinging these spines out at great speed, turning them into one last deadly weapon in their arsenal. To protect oneself against damage from " +
                        "these spines, one should make prodigious use of the Quen Sign."
                        , null
                        , "Toussaint"
                        , "Necrophage Oil"
                        , "Assets\\scurvers.png");

                    //SPOTTED WIGHT
                    Necrophages[13] = new Entry(
                        "Spotted Wight" 
                        , "Spotted wights were a subspecies of wight which the witchers drove to extinction. They were larger than their unspotted kin and owed their names to their numerous blotches and effusions. Spotted " +
                        "wights would most often dwell in derelict cemeteries and empty wildernesses, yet at times took to living in abandoned human domiciles. There they would indulge in their greatest passion: creating " +
                        "brews from their own emissions. When not disturbed, spotted wights would not act aggressively.If threatened, however, they became very dangerous indeed.In the colder months or when faced with an " +
                        "unseasonable chill, they would slip into a state of lethargy, making them easy targets.Even during their active periods, it is said the witchers found a surefire way of besting them, based around " +
                        "careful casting of the Yrden Sign – or at least, so claims witcher lore... Whenever on the one hand witchers swear they have driven a certain species of monster into extinction and one the other " +
                        "someone claims to have seen a member of that species walking around in apparent health, most likely we are dealing with a curse.This rule of thumb showed its worth with the spotted wight from the " +
                        "Trastamara estate.It turned out this creature was in fact a woman transformed into a monster by a curse many years prior, as punishment for refusing food and shelter to a wandering beggar."
                        , "Wight Ear, Wight Hair, Wight Saliva Gland, Wight Trophy, Fork, Disgusting Wight Key"
                        , "Toussaint"
                        , "Necrophage Oil, Igni, and Yrden"
                        , "Assets\\Spotted Wight.png");

                    //WATER HAG
                    Necrophages[14] = new Entry(
                        "Water Hag"
                        , "Some tales mention water hags and swamp bints masquerading as lost old women to lure travelers back to the rickety shacks they build in the wetlands. In truth, only a blind man, or a sighted man " +
                        "blinded with drink, could mistake the rank sludge and rotting carrion of a water hag's den for a cozy cottage, and the hideous hag herself for an innocent grandmother. Their wrinkled, wart-covered " +
                        "bodies stand nearly two yards tall, with skin the color of a long-dead cadaver and stinking of muck and fish. Bony growths two spans long stick out from their backs, with hair like a tangle of seaweed " +
                        "and claws that would make a werewolf proud completing the picture."
                        , "Monster Saliva, Monster Tongue, Venom Extract, Water Essence, Water Hag Mutagen, Water Hag Tooth"
                        , "Velen, White Orchard, and Skellige"
                        , "Northern Wind, Necrophage Oil, Quen, and Igni"
                        , "Assets\\WaterHag.png");

                    //WIGHTS
                    Necrophages[15] = new Entry(
                        "Wights"
                        , "Though wights are ghastly and threatening in appearance, one should not approach them with sword drawn or attack them unprovoked. Left alone, they present no serious danger to anyone and are far more " +
                        "interested in mixing noxious brews in cauldrons than in fighting. This species mainly lives around ancient burial sites, though they have also been spotted near more recently-founded cemeteries and " +
                        "wherever mass graves can be found. Wights spend the winter months in a state of lethargy very similar to human sleep.They live strictly solitary lives-- in fact, it is practically unheard of for these " +
                        "creatures to appear in groups.Yet when they fear their territory is threatened(and it is enough for one to step foot in a wight's territory for it to feel threatened), wights transform into dangerous foes " +
                        "and even abandon their solitary ways to summon other monsters to their aid. It is a certainty that if a wight finds itself in danger, it will immediately spew out an ectoplasmic solution which near " +
                        "instantaneously transforms into barghests.These beasts obey the wight and attack anyone it deems a foe. If one of them is killed, the wight tries to replace it at once. The best strategy when fighting " +
                        "such a wight is to take out the monsters guarding it with the Axii sign before attacking the wight itself.Wights are resistant to poison, but vulnerable to silver."
                        , "Monster Tongue, Wight Hair, Wight Ear, Greater Triglav Runestone, Green Mutagen"
                        , "Toussaint"
                        , "Necrophage Oil, and Axii"
                        , "Assets\\Wights.png");

                }

                /*--------------Ogroid-----------------------
                 
                 Click To Expand*/{

                    //CLOUD GIANT
                    Ogroids[0] = new Entry(
                        "Cloud Giant"
                        , "The Cloud Giant is most likely a degenerated illusory being. He is an inhabitant of the castle in the sky in the Land of a Thousand Fables. This land was " +
                        "abandoned and left untended for years, during which time it began to rot, fester and degrade. The Cloud Giant was most likely meant to be a pleasant - " +
                        "natured strongman who would carry the duke's young daughters on his shoulders and never grow tired. When he became degenerated and overgrown, however, he " +
                        "turned into a dangerous monster. After Jack stole his goose that laid golden eggs, the Cloud Giant decided in the future anyone who climbed onto his cloud " +
                        "would be tossed off, without a word of warning."
                        , "Infused Shards, Cyclop's Eye, Orens, and Greater Red Mutagen"
                        , "Land of a thousand Fables Cloud Giant's Castle"
                        , "Ogroid Oil, Igni, and Dancing Star"
                        , "Assets\\CloudGiant.png");

                    //CYCLOPSES
                    Ogroids[1] = new Entry(
                        "Cyclopses"
                        , "Cyclopses can easily be recognized by the single eye located in the center of their foreheads. If for some reason that is not visible, other tell-tale signs " +
                        "are their enormous size, incredible strength and a seething hatred for all humans."
                        , "Cyclop's Eye, Old Bear Hide, Infused Shard, Monster Brain, Monster Blood, Monster Bone, Monster Ear, Monster Hair, Monster Hide, Monster Hear, Monster Liver," +
                        "Monster Saliva, Monster Tongue, Monster Tooth, and Orens"
                        , "Kaer Morhen, Skellige, and Velen"
                        , "Ogroid Oil, Quen, and Axii"
                        , "Assets\\Cyclopses.png");

                    //GOLYAT
                    Ogroids[2] = new Entry(
                        "Golyat"
                        , "According to legend, Golyat had once been a knight who violated his vows, for which he was punished by the Lady of the Lake. Transformed into a giant, he fled " +
                        "into the mountains and would only descend into the inhabited lowlands when hunger forced him to it. There's no knowing how much truth lies in that legend, yet it " +
                        "is incontrovertible fact that this dangerous giant gobbled up shepherds and sheep alike, and was so widely feared, governesses used him to scare children into eating " +
                        "their vegetables. Though he came across as a wild, unthinking beast, Golyat used simple tools and any item could turn into a deadly weapon in his powerful hands. " +
                        "When fighting Geralt, Golyat wielded a millstone, making his every blow truly crushing.Luckily, Geralt already had some experience slaying giants and made quick work " +
                        "of Golyat as well, with the much appreciated help of three knights - Milton de Peyrac Peyran, Palmerin de Launfal and Guillaume de Launfal."
                        , "Golyat Trophy, Dahlia, and Greater Red Mutagen"
                        , "Dulcinea Windmill in Toussaint"
                        , "Ogroid Oil, and Quen"
                        , "Assets\\Golyat.png");

                    //HAGUBMAN
                    Ogroids[3] = new Entry(
                        "Hagubman"
                        , "Your average nekker is cowardly and weak and only ever attacks in groups, even then only when the group greatly outnumbers its opponents. Yet at times there will " +
                        "appear among them an individual who towers over the rest in terms of strength, stamina and cunning. Such nekkers are usually called warriors, though that name is misleading. " +
                        "Warriors fight with honor, face to face. These overgrown nekkers act more like assassins - they strike by surprise, from hiding, in the back, or when their opponent " +
                        "exposes himself while attacking. Luckily, like other nekkers warriors are vulnerable to all the Signs, and their blows can be easily parried or countered. Such a monster " +
                        "lived near the village of Larvik on Hindarsfjall - and not even the strongest of islanders were capable of slaying it.A witcher though... A witcher's another story."
                        , "Nekker Claw, Nekker Heart, Nekker Warrio's Liver, Nekker Warrior Mutagen, Nekker Warrior Trophy, Devine, Venom Extract"
                        , "Near the village of Larvik on Hindarsfjall"
                        , "Northern Wind and Ogroid Oil"
                        , "Assets\\Hagubman.png");

                    //ICE GIANT
                    Ogroids[4] = new Entry(
                        "Ice Giant"
                        , "This powerful, primeval monster is quite possibly the last of its race. The Ice Giant resembles a man in many respects, but is blue as frost and taller than a tree. " +
                        "Though it seems capable of reason, all attempts to communicate with it to date have ended the same way – in a quick and painful death."
                        , "Elemental Essence, Monster Brain, and Monster Eye"
                        , "Skellige"
                        , "Ogroid Oil and Quen"
                        , "Assets\\IceGiant.png");

                    //ICE TROLL
                    Ogroids[5] = new Entry(
                        "Ice Trolls"
                        , "Climbing to the top of snow-covered peaks is never a safe endeavor. One can slip and fall into a ravine, be buried in an avalanche – or stumble across ice trolls." +
                        " Unlike the rock trolls found at lower altitudes, these permafrost-dwelling monsters treat every man they encounter as a possible ingredient for a tasty meal. Luckily ice " +
                        "trolls live atop high mountain ridges so inaccessible they rarely encounter humans, and some suppose this is why they have not mastered the basics of Common Speech. " +
                        "Others claim their harsh mountain home has stripped them of an ability they once possessed, for in a land of never - ending cold there is no room for mercy or understanding. " +
                        "Ice trolls are crueler than their rocky kin.Though they use similar tactics in battle – tossing stones and swinging with their mighty fists – they are heartier and stronger " +
                        "than rock trolls and thus more dangerous.Like rock trolls, their backs are covered in thick protective armor, meaning one should never strike them from the rear. Meanwhile " +
                        "their mass means that the Aard Sign cannot move them.Lastly, never think of attacking them during a blizzard.At such times they draw power from the surrounding cold and fight with increased strength."
                        , "Troll Hide, Troll Mutagen, and Elemental Essence"
                        , "Skellige"
                        , "Ogroid Oil and Quen"
                        , "Assets\\IceGiant.png");

                    //NEKERS
                    Ogroids[6] = new Entry(
                        "Nekkers"
                        , "A lone nekker is harmless. Five are dangerous. Ten can kill even a veteran monster slayer. Particularly troublesome are the larger, stronger individuals known as warriors, " +
                        "as well as the rare breed of nekkers known as phoocas. Nekkers and phoocas live in the dark woods that grow in damp, mist - filled valleys, in colonies of one to several dozen " +
                        "individuals.They dig deep burrows for lairs and connect them with a network of narrow tunnels.Using these passageways they are able to move at great speed within and around their " +
                        "colonies. Nekkers always attack in groups and by surprise.They try to surround their prey as quickly as possible, cutting off all escape routes.Luckily their attack is for the most " +
                        "part disorganized, for nekkers are not gifted with great courage and individual nekkers will often hesitate before overcoming their fear and striking.When fighting them one can use " +
                        "this moment of hesitation to kill the braver individuals before finishing off those who remain in the back."
                        , "Nekker Blood, Nekker Claw, Nekker Eyes, Nekker Heart, Lesser Blue Mutagen, and Lesser Green Mutagen"
                        , "Velen, White Orchard, Skellige, and Toussaint"
                        , "Northern Wind, and Ogroid Oil"
                        , "Assets\\Nekker.png");

                    //ROCK TROLL
                    Ogroids[7] = new Entry(
                        "Rock Troll"
                        , "If while hiking high in the mountains you come across a walking stone, do not think your eyes deceive you. Instead, draw your sword – for before you stands a rock troll. True, not" +
                        " every encounter with these creatures ends in a fight - while not particularly intelligent, trolls are capable of reason – but it is better to prepare for the worst. Otherwise, your" +
                        " hike might end not on the summit, but in their stew. Trolls are able to use fire and simple tools, and some of them have even mastered the basics of Common Speech.Though linguistic " +
                        "nuances such as conjugations and declinations escape them, they are extremely fond of riddles, rhymes and all sorts of wordplay, a fact a witcher in possession of a bit of wit can use " +
                        "to his advantage. If a fight proves inevitable, one must watch out for the stones these trolls throw with great strength and shocking precision.Their powerful, heavy fists also present " +
                        "a danger, for they can buckle even the sturdiest breastplate or cuirass.Since their backs are covered in a layer of rocky growth, blows delivered from behind will not do them much damage. " +
                        "They must thus be fought directly, standing face to face – and preferably armed with a sword covered in a fresh coating of ogroid oil."
                        , "Cave Troll Liver, Troll Hide, Troll Mutagen, and Monster Heart"
                        , "Novigrad, Kaer Morhen Valley, Skellige, and Velen"
                        , "Ogroid Oil, and Quen"
                        , "Assets\\RockTroll.png");

                    //WHAM-a-WHAM
                    Ogroids[8] = new Entry(
                        "Wham-a-Wham"
                        , "Rock trolls come across as dim-witted, ponderous, slow - stupid, to be frank. It's easy to dismiss them - and even easier to enrage them. When this happens, one's best bet is to run as " +
                        "fast as possible, for an angered rock troll is as deadly as a thundering landslide. The truth held in the case of the massive rock troll known as Wham-a-Wham. His every blow struck like a " +
                        "battering ram - meaning one needed either avoid them entirely or protect oneself with the Quen Sign. Its hard skin meant it was near invulnerable to sword strikes - especially those dealt " +
                        "from behind, where its rock armor is the thickest. The only hope for defeating it lay in taking advantage of its typical troll slowness - especially if further exploited using the Yrden Sign. " +
                        "A certain set of Skellige miners learned first - hand just how dangerous rock trolls can be.Ignoring all warnings, they started to mine a rich silver vein in the cave which Wham - a - Wham" +
                        " called home.They died soon thereafter - crushed or torn to rough bits.This time, a troll's killings were a justified act of self-defense - after all, the witcher reasoned, every troll's cave " +
                        "is his castle."
                        , "Troll Hide, Troll Mutagen, and Cave Troll Trophy"
                        , "Cave near Blandare"
                        , "Ogroid Oil, and Quen"
                        , "Assets\\wham.png");

                 }
            }

            this.InitializeComponent();
              }
    }
}