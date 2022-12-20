using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TpDojo.Migrations
{
    public partial class adddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 1, null, 1244, "Abe Masakatsu" },
                    { 2, null, 472, "Adachi Yasumori" },
                    { 3, null, 675, "Adachi Kagemori" },
                    { 4, null, 601, "Adams William" },
                    { 5, null, 1451, "Aiou Mototsuna" },
                    { 6, null, 82, "Akai Terukage" },
                    { 7, null, 474, "Akao Kiyotsuna" },
                    { 8, null, 624, "Akechi Mitsuhide" },
                    { 9, null, 1084, "Akiyama Nobutomo" },
                    { 10, null, 1229, "Amago Haruhisa" },
                    { 11, null, 1361, "Amago Yoshihisa" },
                    { 12, null, 1537, "Andō Morinari" },
                    { 13, null, 1046, "Ankokuji Ekei" },
                    { 14, null, 223, "Aochi Shigetsuna" },
                    { 15, null, 766, "Aokage Takaakira" },
                    { 16, null, 1538, "Aoki Kazushige" },
                    { 17, null, 521, "Akahori Chohichi" },
                    { 18, null, 88, "Arai Hakuseki" },
                    { 19, null, 150, "Araki Motokiyo" },
                    { 20, null, 903, "Araki Murashige" },
                    { 21, null, 352, "Araki Muratsugu" },
                    { 22, null, 407, "Arima Kihei" },
                    { 23, null, 393, "Asakura Yoshikage" },
                    { 24, null, 141, "Ayame Kagekatsu" },
                    { 25, null, 1427, "Azai Hisamasa" },
                    { 26, null, 1811, "Azai Nagamasa" },
                    { 27, null, 1493, "Azai Sukemasa" },
                    { 28, null, 1477, "Baba Nobufusa" },
                    { 29, null, 1200, "Bessho Nagaharu" },
                    { 30, null, 897, "Chacha" },
                    { 31, null, 187, "Chiba Shusaku Narimasa" },
                    { 32, null, 1719, "Chōsokabe Morichika" },
                    { 33, null, 90, "Chōsokabe Kunichika" },
                    { 34, null, 130, "Chōsokabe Motochika" },
                    { 35, null, 267, "Chōsokabe Nobuchika" },
                    { 36, null, 69, "Collache Eugène" },
                    { 37, null, 1210, "Date Masamune" },
                    { 38, null, 547, "Date Shigezane" },
                    { 39, null, 1147, "Doi Toshikatsu" },
                    { 40, null, 1548, "Etō Shinpei" },
                    { 41, null, 1222, "Endō Naotsune" },
                    { 42, null, 503, "Enjoji Nobutane" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 43, null, 1435, "Enomoto Takeaki" },
                    { 44, null, 1911, "Era Fusahide" },
                    { 45, null, 1996, "Fūma Kotarō" },
                    { 46, null, 1161, "Fuwa Mitsuharu" },
                    { 47, null, 1950, "Fukushima Masanori" },
                    { 48, null, 1408, "Gamō Katahide" },
                    { 49, null, 413, "Gamō Ujisato" },
                    { 50, null, 1550, "Harada Naomasa" },
                    { 51, null, 1078, "Harada Nobutane" },
                    { 52, null, 819, "Harada Sanosuke" },
                    { 53, null, 896, "Hasekura Tsunenaga" },
                    { 54, null, 1234, "Hattori Hanzō" },
                    { 55, null, 457, "Hatano Hideharu" },
                    { 56, null, 831, "Hasegawa Eishin" },
                    { 57, null, 1119, "Hayashizaki Jinsuke Shigenobu" },
                    { 58, null, 50, "Hayashi Narinaga" },
                    { 59, null, 129, "Hijikata Toshizo" },
                    { 60, null, 922, "Hirate Masahide" },
                    { 61, null, 566, "Hitotsubashi Keiki" },
                    { 62, null, 1156, "Hōjō Masako" },
                    { 63, null, 1051, "Hōjō Tokimune" },
                    { 64, null, 1196, "Hōjō Ujiyasu" },
                    { 65, null, 1463, "Hōjō Ujimasa" },
                    { 66, null, 1315, "Honda Tadakatsu" },
                    { 67, null, 1889, "Honda Tadatomo" },
                    { 68, null, 1601, "Honganji Kennyo" },
                    { 69, null, 319, "Horio Yoshiharu" },
                    { 70, null, 156, "Hosokawa Fujitaka" },
                    { 71, null, 1624, "Hosokawa Gracia" },
                    { 72, null, 1121, "Hosokawa Tadaoki" },
                    { 73, null, 1883, "Hotta Masatoshi" },
                    { 74, null, 1565, "Ii Naoaki" },
                    { 75, null, 1848, "Ii Naomasa" },
                    { 76, null, 1470, "Ii Naomori" },
                    { 77, null, 1317, "Ii Naonaka" },
                    { 78, null, 1637, "Ii Naosuke" },
                    { 79, null, 752, "Ii Naotaka" },
                    { 80, null, 1279, "Ii Naotora" },
                    { 81, null, 1702, "Ii Naoyuki" },
                    { 82, null, 1995, "Ii Naozumi" },
                    { 83, null, 348, "Iizasa Ienao" },
                    { 84, null, 1430, "Ijuin Tadaaki" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 85, null, 1430, "Ikeda Tsuneoki" },
                    { 86, null, 688, "Imagawa Ujizane" },
                    { 87, null, 1462, "Imagawa Yoshimoto" },
                    { 88, null, 964, "Imai Kanehira" },
                    { 89, null, 624, "Inaba Yoshimichi" },
                    { 90, null, 1875, "Inugami Nagayasu" },
                    { 91, null, 1178, "Ishida Mitsunari" },
                    { 92, null, 301, "Isshiki Fujinaga" },
                    { 93, null, 1466, "Itagaki Nobukata" },
                    { 94, null, 465, "Itō Hirobumi" },
                    { 95, null, 1389, "Iwanari Tomomichi" },
                    { 96, null, 329, "Jinbo Nagamoto" },
                    { 97, null, 655, "Jonas Tönse" },
                    { 98, null, 1383, "Kannan Kumar(Salem)" },
                    { 99, null, 135, "Kakeda Toshimune" },
                    { 100, null, 392, "Kaneko Ietada" },
                    { 101, null, 1733, "Katagiri Katsumoto" },
                    { 102, null, 165, "Katakura Kojūro" },
                    { 103, null, 240, "Katakura Shigenaga" },
                    { 104, null, 965, "Kataoka Mitsumasa" },
                    { 105, null, 88, "Katō Kiyomasa" },
                    { 106, null, 120, "Kawakami Gensai" },
                    { 107, null, 777, "Kido Takayoshi" },
                    { 108, null, 204, "Kikkawa Hiroie" },
                    { 109, null, 315, "Kimotsuki Kanetsugu" },
                    { 110, null, 343, "Kitamura Kansuke" },
                    { 111, null, 766, "Kobayakawa Hideaki" },
                    { 112, null, 464, "Kobayakawa Hidekane" },
                    { 113, null, 1361, "Kobayakawa Takakage" },
                    { 114, null, 1690, "Konishi Yukinaga" },
                    { 115, null, 921, "Kojima Toyoharu" },
                    { 116, null, 1454, "Kuroda Kanbei" },
                    { 117, null, 1393, "Kuroda Kiyotaka" },
                    { 118, null, 714, "Kusunoki Masashige" },
                    { 119, null, 332, "Kuwana Tarozaemon" },
                    { 120, null, 34, "Kumagai Naozane" },
                    { 121, null, 389, "Maeda Keiji" },
                    { 122, null, 944, "Maeda Matsu" },
                    { 123, null, 1021, "Maeda Nagatane" },
                    { 124, null, 1715, "Maeda Toshiie" },
                    { 125, null, 1025, "Maeda Toshinaga" },
                    { 126, null, 1689, "Maeda Toshitsune" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 127, null, 738, "Magome Kageyu" },
                    { 128, null, 396, "Manabe Akifusa" },
                    { 129, null, 437, "Matsudaira Katamori" },
                    { 130, null, 1069, "Matsudaira Nobutsuna" },
                    { 131, null, 1957, "Matsudaira Nobuyasu" },
                    { 132, null, 443, "Matsudaira Higo no Kami Katamori" },
                    { 133, null, 37, "Matsudaira Sadanobu" },
                    { 134, null, 1499, "Matsudaira Tadayoshi" },
                    { 135, null, 69, "Matsudaira Teru" },
                    { 136, null, 107, "Matsunaga Hisahide" },
                    { 137, null, 1439, "Matsunaga Hisamichi" },
                    { 138, null, 781, "Matsuo Bashō" },
                    { 139, null, 1892, "Matsudaira Motoyasu" },
                    { 140, null, 1071, "Minamoto no Mitsunaka" },
                    { 141, null, 800, "Minamoto no Yoshiie" },
                    { 142, null, 1936, "Minamoto no Yoshimitsu" },
                    { 143, null, 1362, "Minamoto no Yoshinaka" },
                    { 144, null, 1235, "Minamoto no Yoshitomo" },
                    { 145, null, 958, "Minamoto no Yoshitsune" },
                    { 146, null, 328, "Minamoto no Tameyoshi" },
                    { 147, null, 1929, "Minamoto no Yorimasa" },
                    { 148, null, 1651, "Minamoto no Yorimitsu" },
                    { 149, null, 1439, "Minamoto no Yoritomo" },
                    { 150, null, 1580, "Minamoto no Noriyori" },
                    { 151, null, 403, "Minoro Takashi" },
                    { 152, null, 920, "Miura Anjin" },
                    { 153, null, 1553, "Miura Yoshimoto" },
                    { 154, null, 60, "Miyamoto Musashi" },
                    { 155, null, 647, "Miyoshi Chōkei" },
                    { 156, null, 1204, "Miyoshi Kazuhide" },
                    { 157, null, 1074, "Miyoshi Masaga" },
                    { 158, null, 88, "Miyoshi Masayasu" },
                    { 159, null, 1498, "Miyoshi Moriyata" },
                    { 160, null, 1910, "Miyoshi Nagayuki" },
                    { 161, null, 1219, "Miyoshi Yoshitsugu" },
                    { 162, null, 1797, "Mizuno Tadakuni" },
                    { 163, null, 452, "Moniwa Yoshinao" },
                    { 164, null, 502, "Mōri Motonari" },
                    { 165, null, 724, "Mōri Nagasada" },
                    { 166, null, 711, "Mori Nagayoshi" },
                    { 167, null, 790, "Mōri Okimoto" },
                    { 168, null, 1080, "Mori Ranmaru" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 169, null, 1077, "Mōri Takamoto" },
                    { 170, null, 1832, "Mori Tadamasa" },
                    { 171, null, 615, "Mōri Terumoto" },
                    { 172, null, 538, "Mori Yoshinari" },
                    { 173, null, 1634, "Murai Sadakatsu" },
                    { 174, null, 1674, "Nagakura Shinpachi" },
                    { 175, null, 521, "Nagao Harukage" },
                    { 176, null, 1820, "Nagao Kagenobu" },
                    { 177, null, 1367, "Nagao Masakage" },
                    { 178, null, 564, "Nagao Tamekage" },
                    { 179, null, 1120, "Nakagawa Kiyohide" },
                    { 180, null, 103, "Nakaoka Shintarō" },
                    { 181, null, 1665, "Naoe Kagetsuna" },
                    { 182, null, 1993, "Naoe Kanetsugu" },
                    { 183, null, 997, "Narita Kaihime" },
                    { 184, null, 791, "Nene" },
                    { 185, null, 749, "Nihonmatsu Yoshitsugu" },
                    { 186, null, 100, "Niimi Nishiki" },
                    { 187, null, 592, "Niiro Tadamoto" },
                    { 188, null, 1838, "Niwa Nagahide" },
                    { 189, null, 1458, "Niwa Nagashige" },
                    { 190, null, 296, "Oda Hiroyoshi" },
                    { 191, null, 731, "Oda Nobuhide" },
                    { 192, null, 1535, "Oda Nobukata" },
                    { 193, null, 96, "Oda Nobukiyo" },
                    { 194, null, 29, "Oda Nobunaga" },
                    { 195, null, 1829, "Oda Nobutada" },
                    { 196, null, 102, "Oda Nobutomo" },
                    { 197, null, 1502, "Oda Nobukatsu" },
                    { 198, null, 1732, "Oda Nobuyasu" },
                    { 199, null, 13, "Ogasawara Shōsai" },
                    { 200, null, 629, "Ōishi Kuranosuke" },
                    { 201, null, 1938, "Okada Izō" },
                    { 202, null, 1465, "Judge Ooka" },
                    { 203, null, 1700, "Ōta Dōkan" },
                    { 204, null, 629, "Ōtani Yoshitsugu" },
                    { 205, null, 420, "Ōtani Yoshiharu" },
                    { 206, null, 1627, "Ōtomo Sōrin" },
                    { 207, null, 1965, "Okita Sōji" },
                    { 208, null, 1062, "Ōkubo Toshimichi" },
                    { 209, null, 1579, "Okunomiya Masaie" },
                    { 210, null, 1966, "Ōuchi Yoshitaka" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 211, null, 758, "Omy Yoshika" },
                    { 212, null, 1029, "Pore Sufi" },
                    { 213, null, 243, "Reizei Takatoyo" },
                    { 214, null, 493, "Rokkaku Sadayori" },
                    { 215, null, 152, "Rokkaku Yoshiharu" },
                    { 216, null, 1397, "Rokkaku Yoshikata" },
                    { 217, null, 1812, "Rusu Masakage" },
                    { 218, null, 926, "Ryūzōji Takanobu" },
                    { 219, null, 750, "Saigo Kiyokazu" },
                    { 220, null, 1977, "Saigō Masako" },
                    { 221, null, 918, "Sagara Taketō" },
                    { 222, null, 1181, "Saigō Takamori" },
                    { 223, null, 694, "Saigo Yoshikatsu" },
                    { 224, null, 254, "Saitō Dōsan" },
                    { 225, null, 1473, "Saitō Hajime" },
                    { 226, null, 1015, "Saito Musashibō Benkei" },
                    { 227, null, 1535, "Saitō Yoshitatsu" },
                    { 228, null, 832, "Sakai Tadakiyo" },
                    { 229, null, 1606, "Sakai Tadashige" },
                    { 230, null, 1064, "Sakai Tadatsugu" },
                    { 231, null, 1394, "Sakai Tadayo" },
                    { 232, null, 14, "Sakakibara Yasumasa" },
                    { 233, null, 1924, "Sakamoto Ryōma" },
                    { 234, null, 1207, "Sakuma Morimasa" },
                    { 235, null, 785, "Sakuma Nobumori" },
                    { 236, null, 647, "Sanada Akihime" },
                    { 237, null, 991, "Sanada Komatsuhime" },
                    { 238, null, 829, "Sanada Masayuki" },
                    { 239, null, 922, "Sanada Nobuyuki" },
                    { 240, null, 59, "Sanada Yukimura" },
                    { 241, null, 142, "Sasaki Kojirō" },
                    { 242, null, 167, "Sassa Narimasa" },
                    { 243, null, 113, "Sasuke Sarutobi" },
                    { 244, null, 1040, "Serizawa Kamo" },
                    { 245, null, 1535, "Shibata Katsuie" },
                    { 246, null, 745, "Shima Sakon" },
                    { 247, null, 1600, "Shimada Ichirō" },
                    { 248, null, 656, "Shimazu Katsuhisa" },
                    { 249, null, 815, "Shimazu Tadahisa" },
                    { 250, null, 798, "Shimazu Tadatsune" },
                    { 251, null, 731, "Shimazu Tadayoshi" },
                    { 252, null, 1677, "Shimazu Takahisa" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 253, null, 1800, "Shimazu Toyohisa" },
                    { 254, null, 216, "Shimazu Yoshihiro" },
                    { 255, null, 769, "Shimazu Yoshihisa" },
                    { 256, null, 806, "Shindou Hiroshii" },
                    { 257, null, 347, "Sogo Nagayasu" },
                    { 258, null, 178, "Sue Yoshitaka" },
                    { 259, null, 1082, "Tachibana Muneshige" },
                    { 260, null, 394, "Tachibana Dōsetsu" },
                    { 261, null, 368, "Tachibana Ginchiyo" },
                    { 262, null, 211, "Taigen Sessai" },
                    { 263, null, 822, "Taira no Kiyomori" },
                    { 264, null, 869, "Taira Masakado" },
                    { 265, null, 827, "Takahashi Shigetane" },
                    { 266, null, 515, "Takenaka Shigeharu" },
                    { 267, null, 309, "Takasugi Shinsaku" },
                    { 268, null, 323, "Takayama Justo" },
                    { 269, null, 1206, "Takayama Ukon" },
                    { 270, null, 395, "Takechi Hanpeita" },
                    { 271, null, 807, "Takeda Katsuyori" },
                    { 272, null, 1269, "Takeda Nobukatsu" },
                    { 273, null, 1991, "Takeda Nobushige" },
                    { 274, null, 225, "Takeda Shingen" },
                    { 275, null, 1282, "Takenaka Hanbei" },
                    { 276, null, 1697, "Tani Tadasumi" },
                    { 277, null, 1881, "Tōdō Takatora" },
                    { 278, null, 1509, "Toki Yorinari" },
                    { 279, null, 1534, "Tochimitsu Gantyoki" },
                    { 280, null, 66, "Tokugawa Ieyasu" },
                    { 281, null, 337, "Tokugawa Hidetada" },
                    { 282, null, 1203, "Tokugawa Nariaki" },
                    { 283, null, 673, "Tokugawa Yoshinobu" },
                    { 284, null, 1053, "Torii Mototada" },
                    { 285, null, 611, "Toyotomi Hidenaga" },
                    { 286, null, 1740, "Toyotomi Hideyoshi" },
                    { 287, null, 1129, "Toyotomi Hideyori" },
                    { 288, null, 470, "Tozuka Tadaharu" },
                    { 289, null, 1754, "Tsukahara Bokuden" },
                    { 290, null, 76, "Uesugi Kagekatsu" },
                    { 291, null, 1254, "Uesugi Kagetora" },
                    { 292, null, 1253, "Uesugi Kenshin" },
                    { 293, null, 1847, "Ujiie Naotomo" },
                    { 294, null, 1820, "Ukita Naoie" }
                });

            migrationBuilder.InsertData(
                table: "Samurai",
                columns: new[] { "Id", "ArmeId", "Force", "Nom" },
                values: new object[,]
                {
                    { 295, null, 676, "Ukita Okiie" },
                    { 296, null, 1480, "Umezawa Michiharu" },
                    { 297, null, 345, "Usami Sadamitsu" },
                    { 298, null, 767, "Uyama Hisanobu" },
                    { 299, null, 1701, "Wada Shinsuke" },
                    { 300, null, 911, "Watanabe Kazan" },
                    { 301, null, 1813, "Watanabe no Tsuna" },
                    { 302, null, 953, "Yasumero Kenshin" },
                    { 303, null, 633, "Yagyū Jūbei Mitsuyoshi" },
                    { 304, null, 789, "Yagyū Munenori" },
                    { 305, null, 1531, "Yamauchi Kazutoyo" },
                    { 306, null, 791, "Yamada Arinaga" },
                    { 307, null, 1831, "Yamada Arinobu" },
                    { 308, null, 1015, "Yamada Nagamasa" },
                    { 309, null, 1572, "Yamagata Masakage" },
                    { 310, null, 110, "Yamakawa Hiroshi" },
                    { 311, null, 432, "Yamakawa Kenjirō" },
                    { 312, null, 1145, "Yamakawa Naoe" },
                    { 313, null, 1879, "Yamanaka Yukimori" },
                    { 314, null, 1853, "Yamanami Keisuke" },
                    { 315, null, 1385, "Yamaoka Tesshū" },
                    { 316, null, 438, "Yanagawa Kenzaburo" },
                    { 317, null, 175, "Yanagisawa Yoshiyasu" },
                    { 318, null, 614, "Yonekura Shigetsugu" },
                    { 319, null, 1824, "Yūki Hideyasu" },
                    { 320, null, 451, "Yasuke" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Samurai",
                keyColumn: "Id",
                keyValue: 320);
        }
    }
}
