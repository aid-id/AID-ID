var nombre = [
  "Aren",
  "Axe",
  "Bjorn",
  "Daven",
  "Egil",
  "Einar",
  "Erik",
  "Esben",
  "Gerd",
  "Gisli",
  "Haakon",
  "Helge",
  "Hans",
  "Harald",
  "Ivar",
  "Jensen",
  "Jorgen",
  "Lars",
  "Niels",
  "Olaf",
  "Olson",
  "Sigurd",
  "Sven",
  "Thor",
  "Viggora",
  "Astrid",
  "Brenda",
  "Dahlia",
  "Engla",
  "Erika",
  "Eyra",
  "Freya",
  "Gerda",
  "Gunilda",
  "Helga",
  "Helmi",
  "Inga",
  "Ingrid",
  "Kaira",
  "Karen",
  "Kaysa",
  "Krista",
  "Lena",
  "Ludmila",
  "Nilsa",
  "Ondina",
  "Seren",
  "Sigrid",
  "Siriana",
  "Valkiria",
  "Marcos",
  "Pau",
  "Tomás",
  "Mariano",
  "Pedro",
  "Ulises",
  "Mario",
  "Pelayo",
  "Unai",
  "Marti",
  "Plácido",
  "Urbano",
  "Martín",
  "Valentín",
  "Mateo",
  "Pol",
  "Vicente",
  "Matías",
  "Ponce",
  "Víctor",
  "Mauricio",
  "Virgilio",
  "Maximiliano",
  "Rafael",
  "Walter",
  "Máximo",
  "Ramiro",
  "Miguel",
  "Ramón",
  "Xabier",
  "Miguel",
  "Ángel",
  "Raúl",
  "Xavier",
  "Mikel",
  "Ricardo",
  "Ximen",
  "Mohamed",
  "Roberto",
  "Yerai",
  "Rodrigo",
  "Yeray",
  "Nabil",
  "Rogelio",
  "Yunes",
  "Narciso",
  "Román",
  "Yusef",
  "Nathan",
  "Rubén",
  "Nicolás",
  "Salvador",
  "Zenon",
  "Samuel",
  "Zoilo",
  "Octavio",
  "Santiago",
  "Oier",
  "Sebastián",
  "Omar",
  "Sergi",
  "Oriol",
  "Sergio",
  "Silvestre",
  "Pablo",
  "Pancho",
  "Teodoro"
];


var apellido = [
  "Acebes",
  "Acencio",
  "Acero",
  "Acevedo",
  "Aceves",
  "Acha",
  "Adan",
  "Adrian",
  "Agirre",
  "Aguila",
  "Aguilar",
  "Aguilera",
  "Alarcon",
  "Alatorre",
  "Alatriste",
  "Alaves",
  "Alba",
  "Albarado",
  "Albares",
  "Barragan",
  "Barrales",
  "Barranco",
  "Barraza",
  "Barreda",
  "Barreto",
  "Barrientes",
  "Barrientos",
  "Barron",
  "Barros",
  "Barroso",
  "Barsena",
  "Barunda",
  "Barva",
  "Barvosa",
  "Barzena",
  "Bayejo",
  "Baylon",
  "Bazan",
  "Becerra",
  "Cardiel",
  "Cardona",
  "Cardoso",
  "Cariaga",
  "Carillo",
  "Carion",
  "Carlin",
  "Carlon",
  "Carlos",
  "Carmel",
  "Carmona",
  "Carnero",
  "Caro",
  "Carpintero",
  "Carpio",
  "Carrales",
  "Carranco",
  "Carrasco",
  "Carreno",
  "Carrera",
  "Carreto",
  "Carrillo",
  "Carrion",
  "Carrisal",
  "Carrisales",
  "Carriyo",
  "Carrizal",
  "Carro",
  "Carvajal",
  "Casa",
  "Casanoba",
  "Casanova", "",
  "Harris",
  "Haumada",
  "Helguera",
  "Henrique",
  "Henriquez",
  "Heredia",
  "Hererra",
  "Hermoso",
  "Hernandes",
  "Hernandez",
  "Jaramillo",
  "Jaramiyo",
  "Jarquin",
  "Jaso",
  "Jaure",
  "Jauregui",
  "Jauri",
  "Jazo",
  "Jimenes",
  "Jiron",
  "Jonguitud",
  "Juache",
  "Juan",
  "Juares",
  "Jurado",
  "Lilo",
  "Limon",
  "Linan",
  "Linares",
  "Lino",
  "Lira",
  "Lisama",
  "Lisarde",
  "Lisarrag",
  "Olachia",
  "Olaque",
  "Olaya",
  "Oldorica",
  "Olea",
  "Olgin",
  "Olguin",
  "Oliba",
  "Olibares",
  "Olibas",
  "Olibera",
  "Oliva",
  "Olivas",
  "Marcial",
  "Mareno",
  "Mares",
  "Marfil",
  "Margues",
  "Maria",
  "Mariano",
  "Marimon",
  "Marin",
  "Marines",
  "Marroquin", "",
  "Palma",
  "Palmerin",
  "Palo",
  "Paloalto",
  "Paloblanco",
  "Palomar",
  "Palomeque",
  "Palomera",
  "Palomino",
  "Palomo",
  "Palos",
  "Palula",
  "Soliz",
  "Soloriano",
  "Solorsano",
  "Soltero",
  "Sonora",
  "Sordia",
  "Soriano",
  "Sorrilla",
  "Sosa",
  "Sosalla",
  "Sostenes",
  "Sotela",
  "Sotero",
  "Soto",
  "Sotomay"
];


var edad = [];
var altura = [];
var peso = [];
var insuGluc = [];
var glucIdeal = [];
var insuCarbo = [];


var cNom = [];
var cSur = [];

var rName="";
var rSur="";

var nameLong = nombre.length;
var surLong = apellido.length;

for (i = 0; i < 100; i++) {

  rName = nombre[Math.floor(Math.random() * nameLong)];
  cNom[i] = "'" + rName +"'";
}

for (i = 0; i < 100; i++) {

  rSur = apellido[Math.floor(Math.random() * surLong)];
  cSur[i] = "'" + rSur +"'";
}


for (i = 0; i < 100; i++) {
  edad[i] = Math.floor(Math.random() *(60-18));
}

for (i = 0; i < 100; i++) {
 var rNum = Math.floor(Math.random() * (150 - 200)+150);
  var numDec = rNum / 100;
  altura[i] = numDec;

}

for (i = 0; i < 100; i++) {
var rNum = Math.random() * (120 - 50)+50;
  var numDec = rNum.toFixed(2);
  peso[i] = numDec;
}

for (i = 0; i < 100; i++) {
  insuGluc[i] = Math.floor(Math.random() * (50 - 25)+25);
}

for (i = 0; i < 100; i++) {
  
  glucIdeal[i] = Math.floor(Math.random() * (120 - 80)+80);
}

for (i = 0; i < 100; i++) {
  insuCarbo[i] = Math.floor(Math.random() *(12 - 8)+8);
}

/*
console.log("Edad: \n" + edad);
console.log("Nombre: \n" + cNom);
console.log("Apellidos: \n" + cSur);
console.log("Pesos: \n" + peso);
console.log("Altura: \n" + altura);
console.log("Ins/Gluc: \n" + insuGluc);
console.log("GluIdeal: \n" + glucIdeal);
console.log("In/Carb: \n" + insuCarbo);
*/