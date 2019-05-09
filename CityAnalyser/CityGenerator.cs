using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityAnalyser
{
    class CityGenerator
    {
        internal static List<Crossroad> generateCrossroads()
        {
            List<Crossroad> crossroads = new List<Crossroad>();
            crossroads.Add(new Crossroad("Osterleingasse", "Hettenkofergasse", null));
            crossroads.Add(new Crossroad("Osterleingasse", "Baldiagasse", null));
            crossroads.Add(new Crossroad("Beingasse", "Fröbelgasse", null));
            crossroads.Add(new Crossroad("Beingasse", "Wattgasse",
                  new List<Car>() {new Car() {id=1, color = "gelb", ps = 159},
new Car() {id=2, color = "weiss", ps = 304},
new Car() {id=3, color = "violett", ps = 72},
new Car() {id=4, color = "blau", ps = 283},
new Car() {id=5, color = "türkis", ps = 113},
            }));
            crossroads.Add(new Crossroad("Beingasse", "Steinlegasse",
                  new List<Car>() {new Car() {id=6, color = "rot", ps = 71},
new Car() {id=7, color = "türkis", ps = 254},
new Car() {id=8, color = "orange", ps = 221},
new Car() {id=9, color = "beige", ps = 211},
new Car() {id=10, color = "blau", ps = 151},
new Car() {id=11, color = "grün", ps = 91},
new Car() {id=12, color = "silber", ps = 286},
new Car() {id=13, color = "beige", ps = 189},
new Car() {id=14, color = "blau", ps = 302},
new Car() {id=15, color = "weiss", ps = 135},
            }));
            crossroads.Add(new Crossroad("Seeböckgasse", "Nattergasse",
                  new List<Car>() {new Car() {id=16, color = "blau", ps = 285},
new Car() {id=17, color = "violett", ps = 256},
new Car() {id=18, color = "orange", ps = 304},
new Car() {id=19, color = "silber", ps = 226},
new Car() {id=20, color = "violett", ps = 270},
new Car() {id=21, color = "weiss", ps = 99},
new Car() {id=22, color = "blau", ps = 155},
new Car() {id=23, color = "gelb", ps = 289},
new Car() {id=24, color = "weiss", ps = 98},
new Car() {id=25, color = "silber", ps = 69},
            }));
            crossroads.Add(new Crossroad("Seeböckgasse", "Blumberggasse",
                  new List<Car>() {new Car() {id=26, color = "silber", ps = 161},
new Car() {id=27, color = "violett", ps = 290},
new Car() {id=28, color = "violett", ps = 211},
new Car() {id=29, color = "violett", ps = 132},
new Car() {id=30, color = "türkis", ps = 296},
new Car() {id=31, color = "weiss", ps = 188},
new Car() {id=32, color = "blau", ps = 100},
new Car() {id=33, color = "schwarz", ps = 249},
            }));
            crossroads.Add(new Crossroad("Seeböckgasse", "Weiglgasse",
                  new List<Car>() {new Car() {id=34, color = "blau", ps = 192},
new Car() {id=35, color = "orange", ps = 297},
new Car() {id=36, color = "beige", ps = 71},
new Car() {id=37, color = "weiss", ps = 248},
new Car() {id=38, color = "beige", ps = 280},
new Car() {id=39, color = "grün", ps = 224},
new Car() {id=40, color = "grün", ps = 76},
new Car() {id=41, color = "gelb", ps = 268},
            }));
            crossroads.Add(new Crossroad("Seeböckgasse", "Reichsapfelgasse", null));
            crossroads.Add(new Crossroad("Mark-Graf-Rüdiger-Straße", "Ameisbachzeile",
                  new List<Car>() {new Car() {id=42, color = "schwarz", ps = 291},
new Car() {id=43, color = "schwarz", ps = 303},
            }));
            crossroads.Add(new Crossroad("Mark-Graf-Rüdiger-Straße", "Mark-Graf-Rüdiger Straße",
                  new List<Car>() {new Car() {id=44, color = "beige", ps = 210},
new Car() {id=45, color = "orange", ps = 293},
new Car() {id=46, color = "blau", ps = 63},
new Car() {id=47, color = "weiss", ps = 229},
new Car() {id=48, color = "orange", ps = 155},
new Car() {id=49, color = "türkis", ps = 120},
new Car() {id=50, color = "silber", ps = 291},
new Car() {id=51, color = "grün", ps = 297},
new Car() {id=52, color = "beige", ps = 63},
            }));
            crossroads.Add(new Crossroad("Sechshauserstraße", "Gablenzgasse",
                  new List<Car>() {new Car() {id=53, color = "türkis", ps = 145},
new Car() {id=54, color = "beige", ps = 124},
new Car() {id=55, color = "rot", ps = 143},
new Car() {id=56, color = "blau", ps = 219},
new Car() {id=57, color = "türkis", ps = 103},
new Car() {id=58, color = "violett", ps = 280},
new Car() {id=59, color = "silber", ps = 279},
            }));
            crossroads.Add(new Crossroad("Anschützgasse", "Gebrüder-Lang-Gasse",
                  new List<Car>() {new Car() {id=60, color = "beige", ps = 273},
            }));
            crossroads.Add(new Crossroad("Anschützgasse", "Hernalser-Hauptstraße",
                  new List<Car>() {new Car() {id=61, color = "orange", ps = 149},
new Car() {id=62, color = "grün", ps = 264},
new Car() {id=63, color = "weiss", ps = 233},
new Car() {id=64, color = "blau", ps = 245},
new Car() {id=65, color = "weiss", ps = 99},
new Car() {id=66, color = "orange", ps = 178},
new Car() {id=67, color = "weiss", ps = 199},
new Car() {id=68, color = "türkis", ps = 211},
            }));
            crossroads.Add(new Crossroad("Anschützgasse", "Nauseagasse",
                  new List<Car>() {new Car() {id=69, color = "weiss", ps = 221},
new Car() {id=70, color = "grün", ps = 276},
new Car() {id=71, color = "silber", ps = 214},
new Car() {id=72, color = "grün", ps = 111},
new Car() {id=73, color = "orange", ps = 148},
new Car() {id=74, color = "blau", ps = 289},
new Car() {id=75, color = "weiss", ps = 108},
new Car() {id=76, color = "gelb", ps = 96},
new Car() {id=77, color = "violett", ps = 198},
            }));
            crossroads.Add(new Crossroad("Anschützgasse", "Hormayrgasse",
                  new List<Car>() {new Car() {id=78, color = "orange", ps = 264},
new Car() {id=79, color = "weiss", ps = 109},
new Car() {id=80, color = "beige", ps = 145},
new Car() {id=81, color = "rot", ps = 77},
new Car() {id=82, color = "beige", ps = 187},
new Car() {id=83, color = "türkis", ps = 237},
new Car() {id=84, color = "beige", ps = 142},
new Car() {id=85, color = "orange", ps = 286},
            }));
            crossroads.Add(new Crossroad("Anschützgasse", "Lienferldergasse", null));
            crossroads.Add(new Crossroad("Friedrich Kaiser Gasse", "Arltgasse",
                  new List<Car>() {new Car() {id=86, color = "beige", ps = 259},
new Car() {id=87, color = "schwarz", ps = 289},
new Car() {id=88, color = "orange", ps = 72},
new Car() {id=89, color = "weiss", ps = 300},
new Car() {id=90, color = "rot", ps = 306},
            }));
            crossroads.Add(new Crossroad("Friedrich Kaiser Gasse", "Lorenz-Mandlgasse",
                  new List<Car>() {new Car() {id=91, color = "silber", ps = 169},
new Car() {id=92, color = "silber", ps = 290},
new Car() {id=93, color = "orange", ps = 205},
new Car() {id=94, color = "weiss", ps = 223},
new Car() {id=95, color = "silber", ps = 190},
            }));
            crossroads.Add(new Crossroad("Friedrich Kaiser Gasse", "Leopold-Ernst-Gasse", null));
            crossroads.Add(new Crossroad("Friedrich Kaiser Gasse", "Hasnerstraße",
                  new List<Car>() {new Car() {id=96, color = "gelb", ps = 160},
new Car() {id=97, color = "blau", ps = 221},
new Car() {id=98, color = "türkis", ps = 102},
new Car() {id=99, color = "grün", ps = 136},
new Car() {id=100, color = "gelb", ps = 273},
            }));
            crossroads.Add(new Crossroad("Horvathgasse", "Clementinengasse", null));
            crossroads.Add(new Crossroad("Horvathgasse", "Pelzgasse", null));
            crossroads.Add(new Crossroad("Horvathgasse", "Neulerchenfelder Straße", null));
            crossroads.Add(new Crossroad("Alszeile", "Possingergasse", null));
            crossroads.Add(new Crossroad("Kirchstetterngasse", "Goldschlagstraße",
                  new List<Car>() {new Car() {id=101, color = "gelb", ps = 186},
new Car() {id=102, color = "violett", ps = 152},
new Car() {id=103, color = "violett", ps = 227},
new Car() {id=104, color = "blau", ps = 300},
new Car() {id=105, color = "orange", ps = 227},
new Car() {id=106, color = "orange", ps = 157},
new Car() {id=107, color = "violett", ps = 111},
new Car() {id=108, color = "türkis", ps = 86},
new Car() {id=109, color = "türkis", ps = 141},
            }));
            crossroads.Add(new Crossroad("Kirchstetterngasse", "Alliogasse", null));
            crossroads.Add(new Crossroad("Kirchstetterngasse", "Neulerchenfelderstraße",
                  new List<Car>() {new Car() {id=110, color = "blau", ps = 91},
new Car() {id=111, color = "weiss", ps = 287},
new Car() {id=112, color = "türkis", ps = 261},
new Car() {id=113, color = "blau", ps = 284},
            }));
            crossroads.Add(new Crossroad("Kollburggasse", "Montlearstraße",
                  new List<Car>() {new Car() {id=114, color = "violett", ps = 111},
new Car() {id=115, color = "rot", ps = 216},
new Car() {id=116, color = "schwarz", ps = 225},
new Car() {id=117, color = "orange", ps = 245},
new Car() {id=118, color = "beige", ps = 187},
new Car() {id=119, color = "violett", ps = 230},
            }));
            crossroads.Add(new Crossroad("Kollburggasse", "Pater-Schwartz-Gasse", null));
            crossroads.Add(new Crossroad("Kollburggasse", "Julius-Meindl-Gasse", null));
            crossroads.Add(new Crossroad("Zwölfergasse", "Gebrüder-Lang-Gasse",
                  new List<Car>() {new Car() {id=120, color = "weiss", ps = 292},
new Car() {id=121, color = "silber", ps = 160},
new Car() {id=122, color = "schwarz", ps = 135},
new Car() {id=123, color = "türkis", ps = 163},
new Car() {id=124, color = "blau", ps = 219},
new Car() {id=125, color = "orange", ps = 185},
new Car() {id=126, color = "rot", ps = 277},
new Car() {id=127, color = "violett", ps = 264},
new Car() {id=128, color = "schwarz", ps = 198},
new Car() {id=129, color = "silber", ps = 214},
            }));
            crossroads.Add(new Crossroad("Zwölfergasse", "Nobilegasse",
                  new List<Car>() {new Car() {id=130, color = "blau", ps = 119},
new Car() {id=131, color = "weiss", ps = 184},
new Car() {id=132, color = "grün", ps = 107},
new Car() {id=133, color = "grün", ps = 287},
new Car() {id=134, color = "grün", ps = 126},
            }));
            crossroads.Add(new Crossroad("Liebknechtgasse", "Linke Wienzeile",
                  new List<Car>() {new Car() {id=135, color = "blau", ps = 223},
new Car() {id=136, color = "blau", ps = 134},
new Car() {id=137, color = "silber", ps = 141},
new Car() {id=138, color = "weiss", ps = 245},
            }));
            crossroads.Add(new Crossroad("Andergasse", "Braungasse", null));
            crossroads.Add(new Crossroad("Felberstraße", "Toßgasse",
                  new List<Car>() {new Car() {id=139, color = "gelb", ps = 141},
new Car() {id=140, color = "schwarz", ps = 258},
new Car() {id=141, color = "grün", ps = 235},
new Car() {id=142, color = "schwarz", ps = 90},
new Car() {id=143, color = "violett", ps = 132},
new Car() {id=144, color = "orange", ps = 164},
new Car() {id=145, color = "türkis", ps = 173},
            }));
            crossroads.Add(new Crossroad("Felberstraße", "Rosenackerstraße", null));
            crossroads.Add(new Crossroad("Ottakringerstraße", "Anschützgasse",
                  new List<Car>() {new Car() {id=146, color = "schwarz", ps = 175},
new Car() {id=147, color = "silber", ps = 91},
new Car() {id=148, color = "silber", ps = 154},
            }));
            crossroads.Add(new Crossroad("Ottakringerstraße", "Matthias-Schönerergasse",
                  new List<Car>() {new Car() {id=149, color = "orange", ps = 183},
new Car() {id=150, color = "grün", ps = 77},
new Car() {id=151, color = "grün", ps = 79},
new Car() {id=152, color = "orange", ps = 260},
new Car() {id=153, color = "violett", ps = 255},
new Car() {id=154, color = "orange", ps = 83},
new Car() {id=155, color = "blau", ps = 201},
new Car() {id=156, color = "beige", ps = 288},
new Car() {id=157, color = "beige", ps = 269},
            }));
            crossroads.Add(new Crossroad("Ottakringerstraße", "Pretschgogasse",
                  new List<Car>() {new Car() {id=158, color = "türkis", ps = 92},
new Car() {id=159, color = "blau", ps = 296},
new Car() {id=160, color = "grün", ps = 263},
new Car() {id=161, color = "weiss", ps = 93},
new Car() {id=162, color = "beige", ps = 206},
new Car() {id=163, color = "orange", ps = 281},
            }));
            crossroads.Add(new Crossroad("Ferchergasse", "Pouthongasse",
                  new List<Car>() {new Car() {id=164, color = "silber", ps = 161},
new Car() {id=165, color = "violett", ps = 264},
new Car() {id=166, color = "rot", ps = 169},
new Car() {id=167, color = "violett", ps = 120},
            }));
            crossroads.Add(new Crossroad("Ferchergasse", "Liebhartstalstraße",
                  new List<Car>() {new Car() {id=168, color = "blau", ps = 121},
new Car() {id=169, color = "beige", ps = 124},
new Car() {id=170, color = "rot", ps = 206},
new Car() {id=171, color = "gelb", ps = 146},
new Car() {id=172, color = "rot", ps = 203},
new Car() {id=173, color = "türkis", ps = 115},
new Car() {id=174, color = "grün", ps = 247},
new Car() {id=175, color = "orange", ps = 230},
            }));
            crossroads.Add(new Crossroad("Ferchergasse", "Tautenhayngasse",
                  new List<Car>() {new Car() {id=176, color = "violett", ps = 198},
new Car() {id=177, color = "violett", ps = 300},
new Car() {id=178, color = "schwarz", ps = 89},
new Car() {id=179, color = "weiss", ps = 92},
new Car() {id=180, color = "silber", ps = 271},
new Car() {id=181, color = "weiss", ps = 182},
new Car() {id=182, color = "grün", ps = 228},
            }));
            crossroads.Add(new Crossroad("Ferchergasse", "Braungasse",
                  new List<Car>() {new Car() {id=183, color = "beige", ps = 277},
new Car() {id=184, color = "silber", ps = 110},
new Car() {id=185, color = "weiss", ps = 105},
new Car() {id=186, color = "schwarz", ps = 236},
            }));
            crossroads.Add(new Crossroad("Ferchergasse", "Heigerleinstraße",
                  new List<Car>() {new Car() {id=187, color = "rot", ps = 77},
new Car() {id=188, color = "rot", ps = 113},
new Car() {id=189, color = "blau", ps = 65},
new Car() {id=190, color = "schwarz", ps = 259},
new Car() {id=191, color = "schwarz", ps = 171},
new Car() {id=192, color = "rot", ps = 271},
new Car() {id=193, color = "weiss", ps = 244},
new Car() {id=194, color = "orange", ps = 285},
new Car() {id=195, color = "rot", ps = 288},
new Car() {id=196, color = "rot", ps = 211},
            }));
            crossroads.Add(new Crossroad("Rosensteingasse", "Holochergasse",
                  new List<Car>() {new Car() {id=197, color = "grün", ps = 80},
new Car() {id=198, color = "gelb", ps = 77},
new Car() {id=199, color = "beige", ps = 239},
new Car() {id=200, color = "beige", ps = 163},
            }));
            crossroads.Add(new Crossroad("Rosensteingasse", "Johann-Nepomuk-Berger Platz",
                  new List<Car>() {new Car() {id=201, color = "gelb", ps = 200},
new Car() {id=202, color = "blau", ps = 255},
new Car() {id=203, color = "rot", ps = 124},
new Car() {id=204, color = "gelb", ps = 112},
            }));
            crossroads.Add(new Crossroad("Rosensteingasse", "Seitenberggasse", null));
            crossroads.Add(new Crossroad("Rosensteingasse", "Dreihausgasse",
                  new List<Car>() {new Car() {id=205, color = "grün", ps = 106},
new Car() {id=206, color = "orange", ps = 80},
new Car() {id=207, color = "violett", ps = 229},
new Car() {id=208, color = "grün", ps = 144},
new Car() {id=209, color = "blau", ps = 95},
new Car() {id=210, color = "türkis", ps = 199},
new Car() {id=211, color = "blau", ps = 129},
            }));
            crossroads.Add(new Crossroad("Rosensteingasse", "Wiesberggasse",
                  new List<Car>() {new Car() {id=212, color = "türkis", ps = 122},
new Car() {id=213, color = "gelb", ps = 146},
new Car() {id=214, color = "silber", ps = 127},
new Car() {id=215, color = "silber", ps = 309},
new Car() {id=216, color = "silber", ps = 210},
new Car() {id=217, color = "violett", ps = 234},
new Car() {id=218, color = "rot", ps = 304},
new Car() {id=219, color = "türkis", ps = 217},
new Car() {id=220, color = "grün", ps = 288},
new Car() {id=221, color = "türkis", ps = 213},
            }));
            crossroads.Add(new Crossroad("Johann-Nepomuk-Berger Platz", "Oesterleingasse",
                  new List<Car>() {new Car() {id=222, color = "schwarz", ps = 308},
new Car() {id=223, color = "rot", ps = 227},
new Car() {id=224, color = "beige", ps = 62},
new Car() {id=225, color = "gelb", ps = 190},
new Car() {id=226, color = "beige", ps = 279},
new Car() {id=227, color = "gelb", ps = 217},
new Car() {id=228, color = "orange", ps = 269},
new Car() {id=229, color = "schwarz", ps = 140},
new Car() {id=230, color = "silber", ps = 247},
            }));
            crossroads.Add(new Crossroad("Johann-Nepomuk-Berger Platz", "Arltgasse",
                  new List<Car>() {new Car() {id=231, color = "gelb", ps = 265},
            }));
            crossroads.Add(new Crossroad("Paletzgasse", "Comeniusgasse",
                  new List<Car>() {new Car() {id=232, color = "weiss", ps = 252},
new Car() {id=233, color = "beige", ps = 126},
new Car() {id=234, color = "gelb", ps = 162},
new Car() {id=235, color = "rot", ps = 227},
new Car() {id=236, color = "schwarz", ps = 114},
            }));
            crossroads.Add(new Crossroad("Paletzgasse", "Reithoferplatz", null));
            crossroads.Add(new Crossroad("Paletzgasse", "Brüßelgasse",
                  new List<Car>() {new Car() {id=237, color = "weiss", ps = 166},
new Car() {id=238, color = "gelb", ps = 238},
new Car() {id=239, color = "blau", ps = 155},
new Car() {id=240, color = "gelb", ps = 234},
new Car() {id=241, color = "schwarz", ps = 270},
            }));
            crossroads.Add(new Crossroad("Paletzgasse", "Joseph-Weinheber-Platz",
                  new List<Car>() {new Car() {id=242, color = "silber", ps = 201},
new Car() {id=243, color = "schwarz", ps = 289},
new Car() {id=244, color = "blau", ps = 235},
new Car() {id=245, color = "weiss", ps = 98},
new Car() {id=246, color = "blau", ps = 80},
new Car() {id=247, color = "grün", ps = 162},
new Car() {id=248, color = "violett", ps = 165},
new Car() {id=249, color = "orange", ps = 159},
            }));
            crossroads.Add(new Crossroad("Brüsselgasse", "Rosa-Luxemburg-Gasse",
                  new List<Car>() {new Car() {id=250, color = "blau", ps = 196},
new Car() {id=251, color = "rot", ps = 118},
            }));
            crossroads.Add(new Crossroad("Brüsselgasse", "Hütteldorferstraße",
                  new List<Car>() {new Car() {id=252, color = "schwarz", ps = 172},
new Car() {id=253, color = "weiss", ps = 291},
new Car() {id=254, color = "gelb", ps = 200},
new Car() {id=255, color = "blau", ps = 202},
new Car() {id=256, color = "grün", ps = 282},
new Car() {id=257, color = "silber", ps = 289},
new Car() {id=258, color = "grün", ps = 178},
            }));
            crossroads.Add(new Crossroad("Brüsselgasse", "Kollburggasse", null));
            crossroads.Add(new Crossroad("Brüsselgasse", "Hasnerstraße",
                  new List<Car>() {new Car() {id=259, color = "türkis", ps = 80},
new Car() {id=260, color = "weiss", ps = 107},
new Car() {id=261, color = "türkis", ps = 61},
new Car() {id=262, color = "orange", ps = 228},
new Car() {id=263, color = "orange", ps = 106},
new Car() {id=264, color = "rot", ps = 61},
new Car() {id=265, color = "silber", ps = 74},
new Car() {id=266, color = "türkis", ps = 272},
new Car() {id=267, color = "grün", ps = 174},
            }));
            crossroads.Add(new Crossroad("Panikengasse", "Geblergasse",
                  new List<Car>() {new Car() {id=268, color = "orange", ps = 127},
new Car() {id=269, color = "silber", ps = 70},
new Car() {id=270, color = "orange", ps = 78},
new Car() {id=271, color = "grün", ps = 153},
new Car() {id=272, color = "violett", ps = 81},
new Car() {id=273, color = "schwarz", ps = 167},
new Car() {id=274, color = "rot", ps = 254},
new Car() {id=275, color = "silber", ps = 229},
new Car() {id=276, color = "türkis", ps = 249},
            }));
            crossroads.Add(new Crossroad("Haberlgasse", "Steinlegasse", null));
            crossroads.Add(new Crossroad("Haberlgasse", "Weiglgasse",
                  new List<Car>() {new Car() {id=277, color = "beige", ps = 68},
new Car() {id=278, color = "türkis", ps = 247},
new Car() {id=279, color = "beige", ps = 183},
new Car() {id=280, color = "silber", ps = 203},
new Car() {id=281, color = "orange", ps = 75},
new Car() {id=282, color = "blau", ps = 88},
            }));
            crossroads.Add(new Crossroad("Haberlgasse", "Nauseagasse", null));
            crossroads.Add(new Crossroad("Haberlgasse", "Nesselgasse",
                  new List<Car>() {new Car() {id=283, color = "türkis", ps = 277},
new Car() {id=284, color = "schwarz", ps = 192},
new Car() {id=285, color = "schwarz", ps = 178},
new Car() {id=286, color = "beige", ps = 165},
            }));
            crossroads.Add(new Crossroad("Maderspergerstraße", "Rankgasse", null));
            crossroads.Add(new Crossroad("Maderspergerstraße", "Geblergasse",
                  new List<Car>() {new Car() {id=287, color = "grün", ps = 173},
new Car() {id=288, color = "grün", ps = 64},
new Car() {id=289, color = "schwarz", ps = 161},
new Car() {id=290, color = "grün", ps = 169},
new Car() {id=291, color = "beige", ps = 130},
            }));
            crossroads.Add(new Crossroad("Maderspergerstraße", "Pouthongasse",
                  new List<Car>() {new Car() {id=292, color = "schwarz", ps = 148},
new Car() {id=293, color = "grün", ps = 191},
            }));
            crossroads.Add(new Crossroad("Maderspergerstraße", "Nobilegasse",
                  new List<Car>() {new Car() {id=294, color = "beige", ps = 140},
new Car() {id=295, color = "grün", ps = 175},
new Car() {id=296, color = "rot", ps = 236},
            }));
            crossroads.Add(new Crossroad("Maderspergerstraße", "Schwendergasse",
                  new List<Car>() {new Car() {id=297, color = "schwarz", ps = 130},
new Car() {id=298, color = "orange", ps = 295},
            }));
            crossroads.Add(new Crossroad("Diefenbachgasse", "Rhigasgasse",
                  new List<Car>() {new Car() {id=299, color = "türkis", ps = 80},
new Car() {id=300, color = "beige", ps = 113},
new Car() {id=301, color = "weiss", ps = 281},
new Car() {id=302, color = "beige", ps = 182},
new Car() {id=303, color = "beige", ps = 161},
new Car() {id=304, color = "blau", ps = 97},
new Car() {id=305, color = "violett", ps = 252},
new Car() {id=306, color = "rot", ps = 207},
new Car() {id=307, color = "weiss", ps = 179},
new Car() {id=308, color = "schwarz", ps = 209},
            }));
            crossroads.Add(new Crossroad("Diefenbachgasse", "Frauenfelderstraße",
                  new List<Car>() {new Car() {id=309, color = "beige", ps = 181},
new Car() {id=310, color = "schwarz", ps = 209},
            }));
            crossroads.Add(new Crossroad("Diefenbachgasse", "Neulerchenfelder Straße", null));
            crossroads.Add(new Crossroad("Diefenbachgasse", "Joseph-Weinheber-Platz", null));
            crossroads.Add(new Crossroad("Degengasse", "Kendlerstraße", null));
            crossroads.Add(new Crossroad("Degengasse", "Scherlandgasse", null));
            crossroads.Add(new Crossroad("Maroltingergasse", "Enenkelstraße",
                  new List<Car>() {new Car() {id=311, color = "rot", ps = 134},
new Car() {id=312, color = "violett", ps = 239},
            }));
            crossroads.Add(new Crossroad("Maroltingergasse", "Gaullachergasse",
                  new List<Car>() {new Car() {id=313, color = "rot", ps = 117},
new Car() {id=314, color = "blau", ps = 244},
            }));
            crossroads.Add(new Crossroad("Maroltingergasse", "Sulmgasse",
                  new List<Car>() {new Car() {id=315, color = "grün", ps = 169},
new Car() {id=316, color = "rot", ps = 104},
new Car() {id=317, color = "grün", ps = 251},
new Car() {id=318, color = "grün", ps = 87},
new Car() {id=319, color = "orange", ps = 144},
new Car() {id=320, color = "türkis", ps = 266},
new Car() {id=321, color = "gelb", ps = 93},
new Car() {id=322, color = "beige", ps = 79},
new Car() {id=323, color = "gelb", ps = 144},
new Car() {id=324, color = "grün", ps = 209},
            }));
            crossroads.Add(new Crossroad("Märzstraße", "Liebhartstalstraße",
                  new List<Car>() {new Car() {id=325, color = "schwarz", ps = 227},
new Car() {id=326, color = "silber", ps = 187},
new Car() {id=327, color = "beige", ps = 260},
new Car() {id=328, color = "grün", ps = 308},
new Car() {id=329, color = "schwarz", ps = 79},
            }));
            crossroads.Add(new Crossroad("Märzstraße", "Scherlandgasse",
                  new List<Car>() {new Car() {id=330, color = "beige", ps = 159},
new Car() {id=331, color = "orange", ps = 202},
new Car() {id=332, color = "silber", ps = 300},
            }));
            crossroads.Add(new Crossroad("Märzstraße", "Frauenfelderstraße", null));
            crossroads.Add(new Crossroad("Märzstraße", "Hütteldorferstraße",
                  new List<Car>() {new Car() {id=333, color = "silber", ps = 217},
new Car() {id=334, color = "violett", ps = 67},
new Car() {id=335, color = "silber", ps = 308},
new Car() {id=336, color = "grün", ps = 103},
new Car() {id=337, color = "orange", ps = 250},
            }));
            crossroads.Add(new Crossroad("Märzstraße", "Brüßlgasse",
                  new List<Car>() {new Car() {id=338, color = "blau", ps = 198},
new Car() {id=339, color = "türkis", ps = 248},
new Car() {id=340, color = "gelb", ps = 60},
new Car() {id=341, color = "türkis", ps = 180},
new Car() {id=342, color = "grün", ps = 275},
new Car() {id=343, color = "beige", ps = 270},
            }));
            crossroads.Add(new Crossroad("Neuwaldeggerstraße", "Seitenberggasse", null));
            crossroads.Add(new Crossroad("Neuwaldeggerstraße", "Schrekergasse",
                  new List<Car>() {new Car() {id=344, color = "gelb", ps = 200},
new Car() {id=345, color = "violett", ps = 295},
            }));
            crossroads.Add(new Crossroad("Neuwaldeggerstraße", "Wichtelgasse",
                  new List<Car>() {new Car() {id=346, color = "türkis", ps = 165},
new Car() {id=347, color = "grün", ps = 81},
new Car() {id=348, color = "schwarz", ps = 133},
            }));
            crossroads.Add(new Crossroad("Neuwaldeggerstraße", "Reuenthalgasse",
                  new List<Car>() {new Car() {id=349, color = "türkis", ps = 199},
new Car() {id=350, color = "grün", ps = 120},
new Car() {id=351, color = "schwarz", ps = 190},
new Car() {id=352, color = "schwarz", ps = 164},
new Car() {id=353, color = "beige", ps = 82},
new Car() {id=354, color = "rot", ps = 281},
new Car() {id=355, color = "rot", ps = 143},
new Car() {id=356, color = "schwarz", ps = 301},
new Car() {id=357, color = "blau", ps = 198},
            }));
            crossroads.Add(new Crossroad("Artlgasse", "Rückertgasse",
                  new List<Car>() {new Car() {id=358, color = "schwarz", ps = 93},
new Car() {id=359, color = "beige", ps = 79},
new Car() {id=360, color = "beige", ps = 126},
new Car() {id=361, color = "blau", ps = 165},
new Car() {id=362, color = "weiss", ps = 97},
new Car() {id=363, color = "silber", ps = 274},
new Car() {id=364, color = "rot", ps = 145},
new Car() {id=365, color = "violett", ps = 246},
new Car() {id=366, color = "grün", ps = 116},
            }));
            crossroads.Add(new Crossroad("Artlgasse", "Rosenackerstraße",
                  new List<Car>() {new Car() {id=367, color = "weiss", ps = 297},
            }));
            crossroads.Add(new Crossroad("Artlgasse", "Blumberggasse",
                  new List<Car>() {new Car() {id=368, color = "orange", ps = 160},
new Car() {id=369, color = "gelb", ps = 96},
new Car() {id=370, color = "beige", ps = 239},
new Car() {id=371, color = "blau", ps = 145},
new Car() {id=372, color = "violett", ps = 161},
new Car() {id=373, color = "violett", ps = 160},
            }));
            crossroads.Add(new Crossroad("Artlgasse", "Montleartstraße", null));
            crossroads.Add(new Crossroad("Josef Weinheberplatz", "Blumengasse",
                  new List<Car>() {new Car() {id=374, color = "blau", ps = 163},
new Car() {id=375, color = "violett", ps = 298},
new Car() {id=376, color = "blau", ps = 115},
new Car() {id=377, color = "blau", ps = 154},
new Car() {id=378, color = "violett", ps = 238},
new Car() {id=379, color = "blau", ps = 294},
            }));
            crossroads.Add(new Crossroad("Josef Weinheberplatz", "Hofmaklgasse", null));
            crossroads.Add(new Crossroad("Josef Weinheberplatz", "Frauengasse", null));
            crossroads.Add(new Crossroad("Josef Weinheberplatz", "Kellinggasse",
                  new List<Car>() {new Car() {id=380, color = "türkis", ps = 253},
            }));
            crossroads.Add(new Crossroad("Czartoryskigasse", "Brunhildengasse",
                  new List<Car>() {new Car() {id=381, color = "grün", ps = 211},
new Car() {id=382, color = "gelb", ps = 235},
            }));
            crossroads.Add(new Crossroad("Czartoryskigasse", "Hettenkofergasse",
                  new List<Car>() {new Car() {id=383, color = "schwarz", ps = 161},
new Car() {id=384, color = "blau", ps = 209},
new Car() {id=385, color = "orange", ps = 98},
            }));
            crossroads.Add(new Crossroad("Paschinggasse", "Gschwandnergasse",
                  new List<Car>() {new Car() {id=386, color = "beige", ps = 256},
new Car() {id=387, color = "türkis", ps = 299},
new Car() {id=388, color = "orange", ps = 232},
new Car() {id=389, color = "gelb", ps = 265},
            }));
            crossroads.Add(new Crossroad("Paschinggasse", "Taubergasse",
                  new List<Car>() {new Car() {id=390, color = "blau", ps = 104},
new Car() {id=391, color = "schwarz", ps = 142},
new Car() {id=392, color = "gelb", ps = 153},
new Car() {id=393, color = "orange", ps = 134},
new Car() {id=394, color = "grün", ps = 219},
new Car() {id=395, color = "rot", ps = 281},
            }));
            crossroads.Add(new Crossroad("Paschinggasse", "Winterburgergasse", null));
            crossroads.Add(new Crossroad("Paschinggasse", "Lindauergasse",
                  new List<Car>() {new Car() {id=396, color = "silber", ps = 240},
new Car() {id=397, color = "rot", ps = 211},
new Car() {id=398, color = "gelb", ps = 190},
            }));
            crossroads.Add(new Crossroad("Paschinggasse", "Johann-Staud-Straße",
                  new List<Car>() {new Car() {id=399, color = "türkis", ps = 151},
new Car() {id=400, color = "silber", ps = 176},
new Car() {id=401, color = "gelb", ps = 166},
new Car() {id=402, color = "violett", ps = 97},
new Car() {id=403, color = "beige", ps = 115},
new Car() {id=404, color = "grün", ps = 197},
new Car() {id=405, color = "orange", ps = 155},
new Car() {id=406, color = "weiss", ps = 180},
new Car() {id=407, color = "silber", ps = 110},
new Car() {id=408, color = "beige", ps = 157},
            }));
            crossroads.Add(new Crossroad("Ottakringer Straße", "Speckbachergasse",
                  new List<Car>() {new Car() {id=409, color = "gelb", ps = 201},
new Car() {id=410, color = "orange", ps = 94},
            }));
            crossroads.Add(new Crossroad("Enenkelstraße", "Hernalser-Hauptstraße",
                  new List<Car>() {new Car() {id=411, color = "beige", ps = 117},
new Car() {id=412, color = "orange", ps = 139},
new Car() {id=413, color = "weiss", ps = 81},
new Car() {id=414, color = "schwarz", ps = 125},
new Car() {id=415, color = "blau", ps = 125},
new Car() {id=416, color = "türkis", ps = 256},
            }));
            crossroads.Add(new Crossroad("Enenkelstraße", "LiebhartstalstraßeB",
                  new List<Car>() {new Car() {id=417, color = "silber", ps = 166},
new Car() {id=418, color = "silber", ps = 82},
new Car() {id=419, color = "orange", ps = 223},
new Car() {id=420, color = "blau", ps = 196},
new Car() {id=421, color = "violett", ps = 146},
new Car() {id=422, color = "türkis", ps = 173},
new Car() {id=423, color = "violett", ps = 286},
            }));
            crossroads.Add(new Crossroad("Enenkelstraße", "Herklotzgasse", null));
            crossroads.Add(new Crossroad("Weinheimergasse", "Odoakergasse",
                  new List<Car>() {new Car() {id=424, color = "türkis", ps = 129},
new Car() {id=425, color = "schwarz", ps = 256},
new Car() {id=426, color = "türkis", ps = 114},
new Car() {id=427, color = "beige", ps = 114},
new Car() {id=428, color = "weiss", ps = 93},
new Car() {id=429, color = "weiss", ps = 80},
new Car() {id=430, color = "schwarz", ps = 299},
            }));
            crossroads.Add(new Crossroad("Weiglgasse", "Arnethgasse", null));
            crossroads.Add(new Crossroad("Frauengasse", "Liebhartsgasse",
                  new List<Car>() {new Car() {id=431, color = "schwarz", ps = 252},
new Car() {id=432, color = "silber", ps = 111},
            }));
            crossroads.Add(new Crossroad("Frauengasse", "Brunnengasse",
                  new List<Car>() {new Car() {id=433, color = "gelb", ps = 296},
new Car() {id=434, color = "grün", ps = 150},
new Car() {id=435, color = "gelb", ps = 109},
new Car() {id=436, color = "blau", ps = 255},
new Car() {id=437, color = "türkis", ps = 183},
            }));
            crossroads.Add(new Crossroad("Herbststraße", "Beheimgasse", null));
            crossroads.Add(new Crossroad("Herbststraße", "Beringgasse",
                  new List<Car>() {new Car() {id=438, color = "blau", ps = 119},
new Car() {id=439, color = "blau", ps = 157},
new Car() {id=440, color = "beige", ps = 82},
new Car() {id=441, color = "grün", ps = 270},
new Car() {id=442, color = "rot", ps = 189},
            }));
            crossroads.Add(new Crossroad("Pretschgogasse", "Sechshauser Straße", null));
            crossroads.Add(new Crossroad("Pretschgogasse", "Arnethgasse",
                  new List<Car>() {new Car() {id=443, color = "weiss", ps = 91},
new Car() {id=444, color = "grün", ps = 67},
new Car() {id=445, color = "weiss", ps = 160},
new Car() {id=446, color = "violett", ps = 179},
new Car() {id=447, color = "gelb", ps = 132},
new Car() {id=448, color = "türkis", ps = 123},
            }));
            crossroads.Add(new Crossroad("Pretschgogasse", "Czartoryskigasse", null));
            crossroads.Add(new Crossroad("Effingergasse", "Liebhartstraße",
                  new List<Car>() {new Car() {id=449, color = "grün", ps = 227},
new Car() {id=450, color = "gelb", ps = 189},
            }));
            crossroads.Add(new Crossroad("Effingergasse", "Weidmanngasse", null));
            crossroads.Add(new Crossroad("Effingergasse", "Ameisbachzeile", null));
            crossroads.Add(new Crossroad("Effingergasse", "Pater-Schwartz-Gasse",
                  new List<Car>() {new Car() {id=451, color = "türkis", ps = 272},
new Car() {id=452, color = "schwarz", ps = 249},
new Car() {id=453, color = "orange", ps = 112},
            }));
            crossroads.Add(new Crossroad("Effingergasse", "Loeschenkohlgasse", null));
            crossroads.Add(new Crossroad("Dadlergasse", "Waidäckergasse",
                  new List<Car>() {new Car() {id=454, color = "violett", ps = 183},
new Car() {id=455, color = "grün", ps = 270},
new Car() {id=456, color = "beige", ps = 238},
new Car() {id=457, color = "orange", ps = 259},
new Car() {id=458, color = "blau", ps = 99},
            }));
            crossroads.Add(new Crossroad("Dadlergasse", "Alliogasse",
                  new List<Car>() {new Car() {id=459, color = "grün", ps = 229},
new Car() {id=460, color = "blau", ps = 167},
new Car() {id=461, color = "schwarz", ps = 194},
new Car() {id=462, color = "beige", ps = 131},
new Car() {id=463, color = "türkis", ps = 100},
new Car() {id=464, color = "gelb", ps = 153},
new Car() {id=465, color = "gelb", ps = 217},
new Car() {id=466, color = "gelb", ps = 189},
            }));
            crossroads.Add(new Crossroad("Dadlergasse", "Schwendergasse",
                  new List<Car>() {new Car() {id=467, color = "violett", ps = 269},
new Car() {id=468, color = "blau", ps = 160},
            }));
            crossroads.Add(new Crossroad("Dadlergasse", "Rosensteingasse",
                  new List<Car>() {new Car() {id=469, color = "grün", ps = 108},
            }));
            crossroads.Add(new Crossroad("Wurmsergasse", "Pater-Schwartz-Gasse",
                  new List<Car>() {new Car() {id=470, color = "blau", ps = 258},
new Car() {id=471, color = "silber", ps = 229},
new Car() {id=472, color = "violett", ps = 203},
new Car() {id=473, color = "blau", ps = 158},
new Car() {id=474, color = "schwarz", ps = 223},
new Car() {id=475, color = "schwarz", ps = 168},
new Car() {id=476, color = "violett", ps = 119},
new Car() {id=477, color = "weiss", ps = 203},
            }));
            crossroads.Add(new Crossroad("Wurmsergasse", "Maroltingergasse", null));
            crossroads.Add(new Crossroad("Friedmanngasse", "Erlaaerstrasse",
                  new List<Car>() {new Car() {id=478, color = "blau", ps = 280},
new Car() {id=479, color = "blau", ps = 224},
new Car() {id=480, color = "gelb", ps = 92},
new Car() {id=481, color = "beige", ps = 214},
new Car() {id=482, color = "orange", ps = 100},
new Car() {id=483, color = "rot", ps = 267},
            }));
            crossroads.Add(new Crossroad("Friedmanngasse", "Neulerchenfelderstraße", null));
            crossroads.Add(new Crossroad("Friedmanngasse", "Mark-Graf-Rüdiger Straße", null));
            crossroads.Add(new Crossroad("Friedmanngasse", "Kellinggasse",
                  new List<Car>() {new Car() {id=484, color = "türkis", ps = 214},
new Car() {id=485, color = "rot", ps = 85},
new Car() {id=486, color = "beige", ps = 168},
new Car() {id=487, color = "weiss", ps = 121},
            }));
            crossroads.Add(new Crossroad("Baldiagasse", "Andergasse",
                  new List<Car>() {new Car() {id=488, color = "rot", ps = 269},
new Car() {id=489, color = "rot", ps = 293},
new Car() {id=490, color = "violett", ps = 195},
new Car() {id=491, color = "weiss", ps = 295},
new Car() {id=492, color = "türkis", ps = 224},
new Car() {id=493, color = "weiss", ps = 246},
new Car() {id=494, color = "silber", ps = 295},
            }));
            crossroads.Add(new Crossroad("Baldiagasse", "Thaliastraße",
                  new List<Car>() {new Car() {id=495, color = "grün", ps = 207},
new Car() {id=496, color = "orange", ps = 123},
new Car() {id=497, color = "gelb", ps = 296},
new Car() {id=498, color = "gelb", ps = 178},
            }));
            crossroads.Add(new Crossroad("Gablenzgasse", "Blumengasse",
                  new List<Car>() {new Car() {id=499, color = "schwarz", ps = 157},
new Car() {id=500, color = "grün", ps = 161},
new Car() {id=501, color = "weiss", ps = 299},
            }));
            crossroads.Add(new Crossroad("Gablenzgasse", "Mark-Graf-Rüdiger Straße",
                  new List<Car>() {new Car() {id=502, color = "grün", ps = 101},
new Car() {id=503, color = "türkis", ps = 213},
new Car() {id=504, color = "weiss", ps = 283},
new Car() {id=505, color = "violett", ps = 99},
new Car() {id=506, color = "violett", ps = 104},
new Car() {id=507, color = "türkis", ps = 237},
new Car() {id=508, color = "rot", ps = 265},
new Car() {id=509, color = "blau", ps = 157},
new Car() {id=510, color = "orange", ps = 63},
new Car() {id=511, color = "beige", ps = 281},
            }));
            crossroads.Add(new Crossroad("Gablenzgasse", "Gablenzgasse", null));
            crossroads.Add(new Crossroad("Gablenzgasse", "Nauseagasse",
                  new List<Car>() {new Car() {id=512, color = "rot", ps = 241},
new Car() {id=513, color = "weiss", ps = 264},
new Car() {id=514, color = "violett", ps = 296},
            }));
            crossroads.Add(new Crossroad("Erlaaerstrasse", "Holochergasse",
                  new List<Car>() {new Car() {id=515, color = "rot", ps = 69},
new Car() {id=516, color = "orange", ps = 113},
new Car() {id=517, color = "beige", ps = 121},
new Car() {id=518, color = "beige", ps = 172},
            }));
            crossroads.Add(new Crossroad("Erlaaerstrasse", "Geibelgasse",
                  new List<Car>() {new Car() {id=519, color = "grün", ps = 253},
new Car() {id=520, color = "weiss", ps = 258},
new Car() {id=521, color = "blau", ps = 136},
new Car() {id=522, color = "gelb", ps = 217},
new Car() {id=523, color = "rot", ps = 63},
new Car() {id=524, color = "violett", ps = 170},
new Car() {id=525, color = "blau", ps = 143},
new Car() {id=526, color = "weiss", ps = 242},
            }));
            crossroads.Add(new Crossroad("Erlaaerstrasse", "Roterdstraße", null));
            crossroads.Add(new Crossroad("Erlaaerstrasse", "Horvathgasse",
                  new List<Car>() {new Car() {id=527, color = "türkis", ps = 233},
new Car() {id=528, color = "blau", ps = 103},
new Car() {id=529, color = "rot", ps = 191},
new Car() {id=530, color = "weiss", ps = 161},
new Car() {id=531, color = "violett", ps = 216},
new Car() {id=532, color = "türkis", ps = 165},
            }));
            crossroads.Add(new Crossroad("Helblinggasse", "Joseph-Weinheber-Platz",
                  new List<Car>() {new Car() {id=533, color = "rot", ps = 212},
new Car() {id=534, color = "türkis", ps = 71},
new Car() {id=535, color = "rot", ps = 100},
new Car() {id=536, color = "grün", ps = 155},
            }));
            crossroads.Add(new Crossroad("Dornbacherstraße", "Pfenninggeldgasse",
                  new List<Car>() {new Car() {id=537, color = "blau", ps = 307},
new Car() {id=538, color = "weiss", ps = 155},
new Car() {id=539, color = "gelb", ps = 300},
new Car() {id=540, color = "rot", ps = 275},
new Car() {id=541, color = "violett", ps = 181},
new Car() {id=542, color = "violett", ps = 134},
            }));
            crossroads.Add(new Crossroad("Dornbacherstraße", "Diepoldplatz",
                  new List<Car>() {new Car() {id=543, color = "orange", ps = 127},
new Car() {id=544, color = "blau", ps = 303},
new Car() {id=545, color = "gelb", ps = 83},
new Car() {id=546, color = "weiss", ps = 68},
new Car() {id=547, color = "schwarz", ps = 291},
            }));
            crossroads.Add(new Crossroad("Dornbacherstraße", "Panikengasse",
                  new List<Car>() {new Car() {id=548, color = "grün", ps = 74},
new Car() {id=549, color = "weiss", ps = 249},
new Car() {id=550, color = "rot", ps = 116},
new Car() {id=551, color = "türkis", ps = 266},
            }));
            crossroads.Add(new Crossroad("Gomperzgasse", "Tautenhayngasse",
                  new List<Car>() {new Car() {id=552, color = "grün", ps = 79},
new Car() {id=553, color = "grün", ps = 162},
new Car() {id=554, color = "türkis", ps = 78},
new Car() {id=555, color = "beige", ps = 239},
new Car() {id=556, color = "türkis", ps = 177},
            }));
            crossroads.Add(new Crossroad("Gomperzgasse", "Anschützgasse",
                  new List<Car>() {new Car() {id=557, color = "türkis", ps = 266},
new Car() {id=558, color = "gelb", ps = 275},
new Car() {id=559, color = "schwarz", ps = 304},
new Car() {id=560, color = "silber", ps = 269},
new Car() {id=561, color = "türkis", ps = 150},
new Car() {id=562, color = "beige", ps = 239},
new Car() {id=563, color = "silber", ps = 85},
new Car() {id=564, color = "blau", ps = 295},
            }));
            crossroads.Add(new Crossroad("Gomperzgasse", "Nauseagasse", null));
            crossroads.Add(new Crossroad("Gomperzgasse", "Sautergasse", null));
            crossroads.Add(new Crossroad("Gomperzgasse", "Artlgasse",
                  new List<Car>() {new Car() {id=565, color = "grün", ps = 130},
new Car() {id=566, color = "orange", ps = 60},
new Car() {id=567, color = "silber", ps = 86},
            }));
            crossroads.Add(new Crossroad("Schwendergasse", "Degengasse",
                  new List<Car>() {new Car() {id=568, color = "rot", ps = 241},
new Car() {id=569, color = "silber", ps = 256},
new Car() {id=570, color = "rot", ps = 102},
new Car() {id=571, color = "weiss", ps = 184},
new Car() {id=572, color = "violett", ps = 139},
new Car() {id=573, color = "silber", ps = 290},
new Car() {id=574, color = "blau", ps = 79},
new Car() {id=575, color = "silber", ps = 88},
new Car() {id=576, color = "schwarz", ps = 127},
new Car() {id=577, color = "beige", ps = 243},
            }));
            crossroads.Add(new Crossroad("Schwendergasse", "Wattgasse",
                  new List<Car>() {new Car() {id=578, color = "orange", ps = 246},
            }));
            crossroads.Add(new Crossroad("Storchengasse", "Geblergasse", null));
            crossroads.Add(new Crossroad("Storchengasse", "Rötzergasse",
                  new List<Car>() {new Car() {id=579, color = "gelb", ps = 183},
new Car() {id=580, color = "rot", ps = 107},
new Car() {id=581, color = "orange", ps = 94},
new Car() {id=582, color = "orange", ps = 186},
new Car() {id=583, color = "gelb", ps = 198},
new Car() {id=584, color = "gelb", ps = 273},
new Car() {id=585, color = "rot", ps = 240},
new Car() {id=586, color = "gelb", ps = 134},
            }));
            crossroads.Add(new Crossroad("Storchengasse", "Zeillergasse",
                  new List<Car>() {new Car() {id=587, color = "orange", ps = 227},
new Car() {id=588, color = "weiss", ps = 176},
new Car() {id=589, color = "grün", ps = 86},
new Car() {id=590, color = "rot", ps = 103},
new Car() {id=591, color = "orange", ps = 193},
new Car() {id=592, color = "gelb", ps = 145},
new Car() {id=593, color = "schwarz", ps = 231},
new Car() {id=594, color = "beige", ps = 263},
new Car() {id=595, color = "violett", ps = 268},
new Car() {id=596, color = "türkis", ps = 178},
            }));
            crossroads.Add(new Crossroad("Storchengasse", "Fünfhausgasse", null));
            crossroads.Add(new Crossroad("Johann-Staud-Straße", "Andergasse",
                  new List<Car>() {new Car() {id=597, color = "silber", ps = 229},
new Car() {id=598, color = "gelb", ps = 293},
new Car() {id=599, color = "gelb", ps = 285},
new Car() {id=600, color = "grün", ps = 185},
            }));
            crossroads.Add(new Crossroad("Johann-Staud-Straße", "Hyrtlgasse", null));
            crossroads.Add(new Crossroad("Waidäckergasse", "Schellhammergasse",
                  new List<Car>() {new Car() {id=601, color = "silber", ps = 270},
new Car() {id=602, color = "beige", ps = 215},
new Car() {id=603, color = "gelb", ps = 188},
new Car() {id=604, color = "türkis", ps = 116},
new Car() {id=605, color = "schwarz", ps = 296},
            }));
            crossroads.Add(new Crossroad("Waidäckergasse", "Artlgasse",
                  new List<Car>() {new Car() {id=606, color = "rot", ps = 69},
new Car() {id=607, color = "gelb", ps = 256},
new Car() {id=608, color = "rot", ps = 73},
new Car() {id=609, color = "silber", ps = 72},
new Car() {id=610, color = "violett", ps = 307},
            }));
            crossroads.Add(new Crossroad("Herklotzgasse", "Montlearstraße",
                  new List<Car>() {new Car() {id=611, color = "türkis", ps = 124},
new Car() {id=612, color = "beige", ps = 270},
new Car() {id=613, color = "grün", ps = 190},
new Car() {id=614, color = "orange", ps = 101},
new Car() {id=615, color = "silber", ps = 195},
new Car() {id=616, color = "gelb", ps = 213},
new Car() {id=617, color = "orange", ps = 306},
new Car() {id=618, color = "blau", ps = 198},
            }));
            crossroads.Add(new Crossroad("Römergasse", "Leopold-Ernst-Gasse",
                  new List<Car>() {new Car() {id=619, color = "beige", ps = 302},
            }));
            crossroads.Add(new Crossroad("Oeverseestraße", "Braungasse",
                  new List<Car>() {new Car() {id=620, color = "türkis", ps = 110},
new Car() {id=621, color = "rot", ps = 159},
new Car() {id=622, color = "weiss", ps = 128},
new Car() {id=623, color = "schwarz", ps = 62},
            }));
            crossroads.Add(new Crossroad("Oeverseestraße", "Weinheimergasse",
                  new List<Car>() {new Car() {id=624, color = "rot", ps = 229},
new Car() {id=625, color = "blau", ps = 278},
new Car() {id=626, color = "schwarz", ps = 153},
            }));
            crossroads.Add(new Crossroad("Oeverseestraße", "Nauseagasse",
                  new List<Car>() {new Car() {id=627, color = "silber", ps = 68},
new Car() {id=628, color = "blau", ps = 188},
new Car() {id=629, color = "violett", ps = 177},
new Car() {id=630, color = "grün", ps = 204},
            }));
            crossroads.Add(new Crossroad("Oeverseestraße", "Blumengasse",
                  new List<Car>() {new Car() {id=631, color = "türkis", ps = 120},
new Car() {id=632, color = "schwarz", ps = 252},
new Car() {id=633, color = "rot", ps = 207},
new Car() {id=634, color = "rot", ps = 257},
new Car() {id=635, color = "grün", ps = 296},
new Car() {id=636, color = "gelb", ps = 157},
new Car() {id=637, color = "grün", ps = 295},
new Car() {id=638, color = "türkis", ps = 89},
new Car() {id=639, color = "schwarz", ps = 166},
new Car() {id=640, color = "türkis", ps = 214},
            }));
            crossroads.Add(new Crossroad("Julius Meindl Gasse", "Kardinal Rauscher Platz",
                  new List<Car>() {new Car() {id=641, color = "beige", ps = 177},
            }));
            crossroads.Add(new Crossroad("Julius Meindl Gasse", "Liebknechtgasse",
                  new List<Car>() {new Car() {id=642, color = "schwarz", ps = 256},
new Car() {id=643, color = "orange", ps = 192},
new Car() {id=644, color = "silber", ps = 104},
            }));
            crossroads.Add(new Crossroad("Julius Meindl Gasse", "Wurzbachgasse",
                  new List<Car>() {new Car() {id=645, color = "beige", ps = 96},
new Car() {id=646, color = "violett", ps = 139},
new Car() {id=647, color = "blau", ps = 270},
new Car() {id=648, color = "gelb", ps = 98},
new Car() {id=649, color = "weiss", ps = 82},
            }));
            crossroads.Add(new Crossroad("Hernalser-Hauptstraße", "Joseph-Weinheber-Platz", null));
            crossroads.Add(new Crossroad("Scherlandgasse", "Liebhartsgasse", null));
            crossroads.Add(new Crossroad("Scherlandgasse", "Hernalser-Hauptstraße", null));
            crossroads.Add(new Crossroad("Scherlandgasse", "Taubergasse",
                  new List<Car>() {new Car() {id=650, color = "orange", ps = 197},
new Car() {id=651, color = "grün", ps = 239},
new Car() {id=652, color = "schwarz", ps = 81},
new Car() {id=653, color = "silber", ps = 115},
new Car() {id=654, color = "rot", ps = 234},
new Car() {id=655, color = "orange", ps = 301},
new Car() {id=656, color = "silber", ps = 263},
new Car() {id=657, color = "beige", ps = 201},
new Car() {id=658, color = "beige", ps = 101},
            }));
            crossroads.Add(new Crossroad("LiebhartstalstraßeB", "Hormayrgasse",
                  new List<Car>() {new Car() {id=659, color = "weiss", ps = 296},
new Car() {id=660, color = "weiss", ps = 273},
            }));
            crossroads.Add(new Crossroad("LiebhartstalstraßeB", "Mareschgasse",
                  new List<Car>() {new Car() {id=661, color = "schwarz", ps = 64},
new Car() {id=662, color = "türkis", ps = 232},
            }));
            crossroads.Add(new Crossroad("LiebhartstalstraßeB", "Brunnengasse",
                  new List<Car>() {new Car() {id=663, color = "blau", ps = 128},
new Car() {id=664, color = "silber", ps = 199},
new Car() {id=665, color = "gelb", ps = 95},
new Car() {id=666, color = "orange", ps = 118},
new Car() {id=667, color = "weiss", ps = 79},
new Car() {id=668, color = "schwarz", ps = 260},
new Car() {id=669, color = "weiss", ps = 248},
new Car() {id=670, color = "violett", ps = 204},
            }));
            crossroads.Add(new Crossroad("LiebhartstalstraßeB", "Zwinzstraße", null));
            crossroads.Add(new Crossroad("LiebhartstalstraßeB", "Rosa Luxemburggasse", null));
            crossroads.Add(new Crossroad("Graumanngasse", "Julius Meindl Gasse",
                  new List<Car>() {new Car() {id=671, color = "gelb", ps = 157},
            }));
            crossroads.Add(new Crossroad("Graumanngasse", "Wichtelgasse",
                  new List<Car>() {new Car() {id=672, color = "türkis", ps = 121},
new Car() {id=673, color = "grün", ps = 153},
new Car() {id=674, color = "schwarz", ps = 250},
new Car() {id=675, color = "türkis", ps = 174},
new Car() {id=676, color = "türkis", ps = 69},
new Car() {id=677, color = "rot", ps = 156},
new Car() {id=678, color = "weiss", ps = 76},
new Car() {id=679, color = "beige", ps = 74},
            }));
            crossroads.Add(new Crossroad("Graumanngasse", "Waidäckergasse", null));
            crossroads.Add(new Crossroad("Graumanngasse", "Osterleingasse",
                  new List<Car>() {new Car() {id=680, color = "rot", ps = 163},
new Car() {id=681, color = "beige", ps = 122},
new Car() {id=682, color = "gelb", ps = 275},
new Car() {id=683, color = "silber", ps = 171},
new Car() {id=684, color = "weiss", ps = 290},
new Car() {id=685, color = "silber", ps = 204},
new Car() {id=686, color = "violett", ps = 152},
            }));
            crossroads.Add(new Crossroad("Graumanngasse", "Wiesberggasse",
                  new List<Car>() {new Car() {id=687, color = "violett", ps = 82},
            }));
            crossroads.Add(new Crossroad("Weißgasse", "Enenkelstraße",
                  new List<Car>() {new Car() {id=688, color = "silber", ps = 273},
new Car() {id=689, color = "grün", ps = 127},
new Car() {id=690, color = "grün", ps = 297},
            }));
            crossroads.Add(new Crossroad("Veronikagasse", "Mareschgasse", null));
            crossroads.Add(new Crossroad("Gebrüder-Lang-Gasse", "Karl-Metsch-Gasse", null));
            crossroads.Add(new Crossroad("Gebrüder-Lang-Gasse", "Pillergasse", null));
            crossroads.Add(new Crossroad("Gebrüder-Lang-Gasse", "Osterleingasse", null));
            crossroads.Add(new Crossroad("Albrechtskreithgasse", "Hellgasse",
                  new List<Car>() {new Car() {id=691, color = "rot", ps = 224},
            }));
            crossroads.Add(new Crossroad("Rankgasse", "Hasnerstraße",
                  new List<Car>() {new Car() {id=692, color = "orange", ps = 162},
            }));
            crossroads.Add(new Crossroad("Rankgasse", "Ferchergasse", null));
            crossroads.Add(new Crossroad("Rankgasse", "Brunhildengasse",
                  new List<Car>() {new Car() {id=693, color = "orange", ps = 176},
new Car() {id=694, color = "grün", ps = 124},
new Car() {id=695, color = "türkis", ps = 140},
            }));
            crossroads.Add(new Crossroad("Rankgasse", "Plunkergasse",
                  new List<Car>() {new Car() {id=696, color = "gelb", ps = 285},
new Car() {id=697, color = "grün", ps = 147},
new Car() {id=698, color = "türkis", ps = 103},
new Car() {id=699, color = "beige", ps = 296},
new Car() {id=700, color = "orange", ps = 220},
new Car() {id=701, color = "beige", ps = 286},
new Car() {id=702, color = "orange", ps = 235},
new Car() {id=703, color = "rot", ps = 155},
new Car() {id=704, color = "blau", ps = 275},
new Car() {id=705, color = "silber", ps = 175},
            }));
            crossroads.Add(new Crossroad("Rankgasse", "Koberweingasse",
                  new List<Car>() {new Car() {id=706, color = "gelb", ps = 223},
new Car() {id=707, color = "weiss", ps = 259},
new Car() {id=708, color = "beige", ps = 220},
new Car() {id=709, color = "beige", ps = 150},
new Car() {id=710, color = "weiss", ps = 141},
new Car() {id=711, color = "schwarz", ps = 179},
new Car() {id=712, color = "violett", ps = 110},
new Car() {id=713, color = "silber", ps = 273},
new Car() {id=714, color = "schwarz", ps = 126},
            }));
            crossroads.Add(new Crossroad("Kardinal Rauscher Platz", "Gaullachergasse",
                  new List<Car>() {new Car() {id=715, color = "orange", ps = 268},
            }));
            crossroads.Add(new Crossroad("Kardinal Rauscher Platz", "Römergasse",
                  new List<Car>() {new Car() {id=716, color = "violett", ps = 124},
            }));
            crossroads.Add(new Crossroad("Kardinal Rauscher Platz", "Kardinal Rauscher Platz",
                  new List<Car>() {new Car() {id=717, color = "weiss", ps = 167},
new Car() {id=718, color = "silber", ps = 288},
new Car() {id=719, color = "gelb", ps = 102},
new Car() {id=720, color = "orange", ps = 145},
new Car() {id=721, color = "orange", ps = 267},
new Car() {id=722, color = "beige", ps = 274},
new Car() {id=723, color = "rot", ps = 275},
new Car() {id=724, color = "beige", ps = 111},
            }));
            crossroads.Add(new Crossroad("Gaullachergasse", "Blumengasse",
                  new List<Car>() {new Car() {id=725, color = "schwarz", ps = 227},
new Car() {id=726, color = "weiss", ps = 102},
            }));
            crossroads.Add(new Crossroad("Gaullachergasse", "Zwölfergasse", null));
            crossroads.Add(new Crossroad("Paltaufgasse", "Julius Meindl Gasse",
                  new List<Car>() {new Car() {id=727, color = "grün", ps = 272},
            }));
            crossroads.Add(new Crossroad("Paltaufgasse", "Pelzgasse",
                  new List<Car>() {new Car() {id=728, color = "gelb", ps = 213},
new Car() {id=729, color = "silber", ps = 198},
new Car() {id=730, color = "violett", ps = 252},
new Car() {id=731, color = "beige", ps = 111},
            }));
            crossroads.Add(new Crossroad("Paltaufgasse", "Josef-Weinheber Platz", null));
            crossroads.Add(new Crossroad("Paltaufgasse", "Sulmgasse",
                  new List<Car>() {new Car() {id=732, color = "silber", ps = 308},
new Car() {id=733, color = "orange", ps = 261},
new Car() {id=734, color = "weiss", ps = 171},
new Car() {id=735, color = "silber", ps = 262},
new Car() {id=736, color = "gelb", ps = 192},
            }));
            crossroads.Add(new Crossroad("Loeschenkohlgasse", "Stöberplatz",
                  new List<Car>() {new Car() {id=737, color = "silber", ps = 194},
new Car() {id=738, color = "türkis", ps = 234},
new Car() {id=739, color = "rot", ps = 167},
new Car() {id=740, color = "blau", ps = 140},
new Car() {id=741, color = "grün", ps = 249},
new Car() {id=742, color = "rot", ps = 107},
            }));
            crossroads.Add(new Crossroad("Loeschenkohlgasse", "Diefenbachgasse",
                  new List<Car>() {new Car() {id=743, color = "blau", ps = 223},
new Car() {id=744, color = "schwarz", ps = 302},
            }));
            crossroads.Add(new Crossroad("Zwinzstraße", "Gschwandnergasse",
                  new List<Car>() {new Car() {id=745, color = "blau", ps = 201},
new Car() {id=746, color = "türkis", ps = 61},
new Car() {id=747, color = "orange", ps = 168},
new Car() {id=748, color = "violett", ps = 264},
            }));
            crossroads.Add(new Crossroad("Zwinzstraße", "Odoakergasse",
                  new List<Car>() {new Car() {id=749, color = "weiss", ps = 212},
new Car() {id=750, color = "violett", ps = 230},
new Car() {id=751, color = "violett", ps = 254},
new Car() {id=752, color = "silber", ps = 132},
new Car() {id=753, color = "violett", ps = 114},
new Car() {id=754, color = "weiss", ps = 229},
            }));
            crossroads.Add(new Crossroad("Zwinzstraße", "Steinlegasse",
                  new List<Car>() {new Car() {id=755, color = "grün", ps = 108},
new Car() {id=756, color = "grün", ps = 232},
            }));
            crossroads.Add(new Crossroad("Zwinzstraße", "Gaullachergasse",
                  new List<Car>() {new Car() {id=757, color = "blau", ps = 169},
new Car() {id=758, color = "silber", ps = 82},
new Car() {id=759, color = "schwarz", ps = 244},
            }));
            crossroads.Add(new Crossroad("Lorenz.Mandl-Gasse", "Liebknechtgasse",
                  new List<Car>() {new Car() {id=760, color = "beige", ps = 271},
new Car() {id=761, color = "gelb", ps = 265},
new Car() {id=762, color = "schwarz", ps = 164},
new Car() {id=763, color = "beige", ps = 146},
            }));
            crossroads.Add(new Crossroad("Lorenz.Mandl-Gasse", "Josef Weinheber Platz", null));
            crossroads.Add(new Crossroad("Lorenz.Mandl-Gasse", "Taubergasse",
                  new List<Car>() {new Car() {id=764, color = "weiss", ps = 268},
new Car() {id=765, color = "silber", ps = 261},
new Car() {id=766, color = "schwarz", ps = 294},
new Car() {id=767, color = "blau", ps = 269},
new Car() {id=768, color = "blau", ps = 266},
new Car() {id=769, color = "silber", ps = 96},
new Car() {id=770, color = "orange", ps = 177},
            }));
            crossroads.Add(new Crossroad("Lorenz.Mandl-Gasse", "Felberstraße",
                  new List<Car>() {new Car() {id=771, color = "beige", ps = 228},
new Car() {id=772, color = "weiss", ps = 79},
new Car() {id=773, color = "schwarz", ps = 258},
new Car() {id=774, color = "türkis", ps = 223},
new Car() {id=775, color = "blau", ps = 251},
new Car() {id=776, color = "beige", ps = 144},
            }));
            crossroads.Add(new Crossroad("Lorenz.Mandl-Gasse", "Neulerchenfelder Straße",
                  new List<Car>() {new Car() {id=777, color = "orange", ps = 99},
            }));
            crossroads.Add(new Crossroad("Österleingasse", "Julius Meindl Gasse",
                  new List<Car>() {new Car() {id=778, color = "weiss", ps = 250},
new Car() {id=779, color = "rot", ps = 120},
new Car() {id=780, color = "beige", ps = 151},
new Car() {id=781, color = "rot", ps = 272},
new Car() {id=782, color = "beige", ps = 139},
new Car() {id=783, color = "grün", ps = 113},
new Car() {id=784, color = "blau", ps = 197},
new Car() {id=785, color = "violett", ps = 115},
            }));
            crossroads.Add(new Crossroad("Matthias-Schönerergasse", "Minciostraße", null));
            crossroads.Add(new Crossroad("Matthias-Schönerergasse", "Rückertgasse",
                  new List<Car>() {new Car() {id=786, color = "beige", ps = 71},
new Car() {id=787, color = "weiss", ps = 85},
            }));
            crossroads.Add(new Crossroad("Matthias-Schönerergasse", "Paltaufgasse",
                  new List<Car>() {new Car() {id=788, color = "gelb", ps = 100},
new Car() {id=789, color = "rot", ps = 265},
new Car() {id=790, color = "blau", ps = 96},
new Car() {id=791, color = "violett", ps = 245},
            }));
            crossroads.Add(new Crossroad("Montleartstraße", "Turnergasse", null));
            crossroads.Add(new Crossroad("Montleartstraße", "Paletzgasse", null));
            crossroads.Add(new Crossroad("Montleartstraße", "Minciostraße",
                  new List<Car>() {new Car() {id=792, color = "violett", ps = 164},
new Car() {id=793, color = "gelb", ps = 137},
new Car() {id=794, color = "weiss", ps = 147},
new Car() {id=795, color = "grün", ps = 153},
new Car() {id=796, color = "beige", ps = 197},
new Car() {id=797, color = "schwarz", ps = 141},
new Car() {id=798, color = "orange", ps = 249},
new Car() {id=799, color = "beige", ps = 229},
new Car() {id=800, color = "orange", ps = 194},
            }));
            crossroads.Add(new Crossroad("Montleartstraße", "Montleartstraße", null));
            crossroads.Add(new Crossroad("Hellgasse", "Effingergasse", null));
            crossroads.Add(new Crossroad("Hellgasse", "Blumberggasse",
                  new List<Car>() {new Car() {id=801, color = "beige", ps = 177},
            }));
            crossroads.Add(new Crossroad("Hellgasse", "Liebhartsgasse", null));
            crossroads.Add(new Crossroad("Hellgasse", "Hütteldorferstraße", null));







            return crossroads;
        }
    }
}
