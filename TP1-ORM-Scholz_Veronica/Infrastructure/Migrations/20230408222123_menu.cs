using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 33);

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 1,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=19RZ1fcdX8FaYZapFayXSKkvSeh_eD8sx", "Berenjenas, vinagre, aceite de oliva, ajo, laurel, orégano, pimentón, sal. ", 500, "Cortar las berenjenas y colocarlas en una olla con vinagre y agua. Hervir y colocar las rodajas en un frasco de vidrio esterilizado. Cubrirlas con ajo picado y agregar sal y aceite a gusto. Dejar reposar durante 24 horas antes de consumir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 2,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1xdVsFI-bfmKKrxUOoRvLwNy_tpZi1tlL", "Porotos, cebolla, ají molido, vinagre, aceite, sal y pimienta. ", "Porotos a la vinagreta", 500, "Saltear la cebolla. Agregar ají molido, el vinagre y cocinar hasta que hierva. En un frasco de vidrio esterilizado, colocar los porotos y cubrir con la mezcla de cebolla. Dejar reposar durante 24 horas antes de consumir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 3,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=18PT8STxFOdbqcWPo2qbEeX-dmHqrKL4U", "Garbanzos cocidos, jugo de limón, aceite de oliva, ajo, sal y comino. ", 500, "Colocar los garbanzos, el jugo de limón, el ajo, el comino, la sal y procesar hasta obtener una pasta suave. Agregar aceite de oliva hasta obtener la consistencia deseada. Servir con tostaditas con ajo." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 4,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=10KYo-Sx37qfrCCJb2NDwjfBwc0x7k6ya", "Carne de vaca, pan rallado, huevo, salsa de tomate, jamón, queso y aceite para freír.", 1500, "Desgrasar la carne y dejar reposar en un recipiente con huevo batido, ajo, perejil, sal y pimienta. Pasar por pan rallado. Freír en aceite caliente hasta que esté dorado y crujiente. Cubrir con salsa de tomate, jamón y queso y hornear." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 5,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1I1Q6EtlwXY8hCll7GSrXut1aMtjBWCZe", "Papas, aceite y sal.", 1000, "Pelar y cortar las papas en tiras delgadas. Freír en aceite caliente hasta que estén doradas y crujientes. Escurrir y salar al gusto." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 6,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1f-ZxsKFvooSuCWt1KWnX3xn6DnAF4Z88", "Masa de empanada, carne picada, cebolla, huevo duro, ají molido, sal, cebolla de verdeo.", 400, "Cocinar la carne con cebolla, ají molido y sal. Agregar huevo duro y cebolla de verdero picada. Armar las empanadas y hornear." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 7,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1o9q6P2my5mlVrtxmPE-vLHNDv62psRAq", "Huevos, queso fresco, orégano, sal y pimienta", 900, "Batir los huevos con sal y pimienta. Verter en la sartén antiadherente. Agregar queso y oregano. Enrollar y servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 8,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=11wwHdYe4Zi0eMRrhay3cRzpywlsBbr2a", "Masa para tarta, jamón, queso, tomate, huevos, sal y pimienta.", 2500, "Estirar la masa para tarta en un molde. Cubrir con jamón, tomate y queso. Batir los huevos con sal y pimienta. Verter sobre la tarta. Cubrir con masa y hornear." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 9,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=15lJhT2aRy3StYLz76Ikt33Z-ViZaN8nS", "Fideos, queso crema, queso parmesano, queso roquefort, queso rallado, leche, manteca.", 2100, "Cocinar los fideos según las instrucciones del paquete. Mezclar en una sartén la leche con los quesos, a fuego bajo hasta que se derritan. Agregar la manteca y revolver. Servir la salsa sobre los fideos." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 10,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1kYYKJPH865M4a4uoF9FrC0kOkONntdPn", "Ñoquis, carne picada, cebolla, ajo, tomate, aceite, albahaca, sal y pimienta", "Ñoquis con Salsa Bolognesa", 2500, "Dorar el ajo y agregar cebolla en aceite hasta dorar. Agregar la carne. Agregar tomate picado, albahaca y dejar reducir. Cocinar a fuego bajo. Servir sobre los ñoquis." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 11,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1HujVQHj9rpi4NpW_Dteve04cGO760-Q6", "Sorrentinos, tomate, cebolla, ajo, aceite, sal y pimienta.", 2500, "Cocinar los sorrentinos según las instrucciones del paquete. En una sartén, dorar cebolla y ajo picados en aceite. Agregar tomate picado y cocinar. Dejar reducir. Cocinar a fuego bajo. Servir sobre los sorrentinos." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 12,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1Zca5YZ3-d9-R9mpBcKJNPloodPNyO5mK", "Queso provolone, orégano, aceite de oliva.", 1200, "Cortar el queso en rodajas y rociar con aceite de oliva. Espolvorear orégano. Cocinar a la parrilla o en sartén hasta que esté dorado." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 13,
                columns: new[] { "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "Asado, vacio, chorizo, morcilla, chinchulines, riñones, mollejas, sal y limón.", 2000, "Salar la carne y cocinar en la parrilla a fuego medio. Servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 14,
                columns: new[] { "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "Asado, vacio, chorizo, morcilla, chinchulines, riñones, mollejas, sal y limón.", 3000, "Salar la carne y cocinar en la parrilla a fuego medio. Servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 15,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1D05vfv2K1VokG5KlXzsxLBLWrqRteAjc", "Harina, levadura, aceite y sal. Salsa de tomate, ajo, queso muzzarella, aceitunas. ", 2300, "Dejar levar la levadura con agua tibia. Mezclar con harina y sal, amasar y dejar reposar untada en aceite. Formar bollos y dejar reposar. Precocinar a la parrilla, agregar salsa de tomate, queso y hornear con bandeja encima. Agregar aceitunas y servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 16,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1_FdIEzrM-QS5H78syVAoRX9htrZUCQ7T", "Harina, levadura, aceite y sal. Tomate, ajo, albahaca, queso muzzarella, aceitunas. ", 2500, "Levar levadura con agua tibia. Añadir a recipiente con harina y sal. Amasar y dejar reposar untada en aceite. Formar bollos y reposar. Precocinar en parrilla. Agregar salsa, queso y hornear. Añadir tomate, ajo, albahaca, aceitunas. Servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 17,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1ekxSyUVbsuGzl00I5bIRYUt0Ntv2bmRC", "Harina, levadura, aceite y sal. Salsa de tomate, ajo, queso muzzarella, rucula, jamon crudo, tomate cherry, aceitunas negras. ", "Rucula y jamon crudo", 3000, "Levar la levadura, mezclar con harina y sal. Reposar la masa en aceite y tapar. Formar bollos y reposar. Precocinar la masa en parrilla, agregar salsa, queso, bandeja y hornear. Agregar jamón crudo, rúcula, tomate cherry, aceitunas y servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 18,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1U_FDLjY-DvNft-6vYpDSwCM50VBdkWmR", "Harina, levadura, aceite y sal. Queso muzzarella, jamon cocido, cebolla.", 3200, "Dejar levar la levadura con agua tibia. Agregar harina y sal.Amasar y dejar reposar la masa en aceite tapada.Formar bollos y dejar reposar.Extender masa en bandeja.Agregar jamon y queso.Tapar con masa y cebolla.Hornear y servir." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 19,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1MvwhTPB-mIU2U7a_ZEjjgj3QhbMXOJ1B", "Pan de hamburguesa, carne picada, lechuga, tomate, cebolla, queso cheddar.", 1000, "Mezclar carne picada, ajo, perejil, sal, pimienta, huevo. Formar bolitas con pan rallado. Aplastar y cocinar en parrilla o sartén. Agregar cheddar y dar vuelta. Armar hamburguesa con carne, lechuga, tomate y cebolla en pan." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 20,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1RCO7t5V9v5nMA7mUIMeSzpqDyVDVLWcR", "Lechuga, cebolla, aceite de giralsol, vinagre de alcohol.", "Lechuga y Cebolla", 700, "Cortar la lechuga en trozos y la cebolla en juliana. Mezclar en un recipiente y agregar aceite, vinagre y sal.", 7 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 21,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1AT0FKcyPQ_YGsRma5Ngu6GX8ftf8Ywwd", "Agua.", "Agua", 500, "Servir en un vaso.", 8 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 22,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1LgUFou-0XV4ZGXLvl0VdOudpB2xNowUQ", "Agua con gas.", "Agua con gas", 500, "Servir en un vaso." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 23,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=19_2s9DOCYfjSeOM8oOMjfPLZQxrIbrax", "CocaCola.", "CocaCola", 700, "Servir en un vaso." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 24,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1GPpCuTHDb_YfZ5WgfBpwnh6gCZ4UzYh9", "Agua Tonica", "Agua Tonica", 700, "Servir en un vaso." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 25,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=17DJ0vDYpvAlRvFtfor2hVXmB3nb6p5KK", "Vino de la casa.", "Vino", 2000, "Servir en una copa." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 26,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1SdRfF1u3J6ejfsoYoMIiXLSaplHcNaDS", "Maltas claras, lupulos suaves y agua.", "Blonde Ale", 700, "Se mezclan los ingredientes en agua caliente para producir mosto. Luego se agrega levadura para la fermentación, y después de algunos días, se empaqueta en barriles para la carbonatación. Finalmente, se enfría y se sirve.", 9 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 27,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1uNGK3SZOYrbb4SkF9TZpEhw-qQ1i_6Su", "Maltas oscuras, lupulos amargos, agua y miel.", "Honey", 700, "Se mezclan los ingredientes en agua caliente para producir mosto. Luego se agrega levadura para la fermentación, y después de algunos días, se empaqueta en barriles para la carbonatación. Finalmente, se enfría y se sirve." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 28,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1dupPwq4BpsOAfeloQt0zncUPgS5b8TSL", "Maltas palidas, lupulos fuertes y agua.", "Scottish", 700, "Se mezclan los ingredientes en agua caliente para producir mosto. Luego se agrega levadura para la fermentación, y después de algunos días, se empaqueta en barriles para la carbonatación. Finalmente, se enfría y se sirve." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 29,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1ElTRsSRJST0nTWKSsfQkR4XSeNhlI6Al", "Pan, leche, huevos, azúcar, pasas de uva, esencia de vainilla. ", "Budin de Pan", 800, "Remojar el pan en la mezcla de leche, huevos, azúcar y vainilla. Agregar pasas y hornear.", 10 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 30,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1wq625i2tDiHzQRVGrU_i3hYJpzuPwryc", "Helado, salsa de chocolate y crema. ", "Copa Helada", 800, "Colocar el helado en una copa y cubrir con la salsa de chocolate. Agregar crema batida." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 31,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1Jmqg2GaZ0Whmq-yzxgtNOOBCi8k2dIwL", "Harina, leche, huevos, sal, dulce de leche. ", "Panqueques con dulce de leche", 800, "Batir leche, huevo y harina con una pizca de sal. Cocinar en sartén caliente. Untar con dulce de leche y enrollar." });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 32,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "http://drive.google.com/uc?export=view&id=1NX-GToSUk1pqMHpU6K0r453GlJOt3HH4", "Frutillas, crema batida, azúcar. ", "Frutillas con Crema", 800, "Cortar las frutillas, agregar azúcar y dejar reposar. Servir con crema batida." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 1,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Berenjenas en Escabeche (ingredientes)", 100, "Berenjenas en Escabeche (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 2,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Porotos en Escabeche (ingredientes)", "Porotos en Escabeche", 100, "Porotos en Escabeche (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 3,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Humus de Garbanzo (ingredientes)", 100, "Humus de Garbanzo (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 4,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Milanesa Napolitana (ingredientes)", 100, "Milanesa Napolitana (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 5,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Papas Fritas (ingredientes)", 100, "Papas Fritas (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 6,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Empanada (ingredientes)", 100, "Empanada (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 7,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Omelette (ingredientes)", 100, "Omelette (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 8,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Tarta (ingredientes)", 100, "Tarta (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 9,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Fideos con salsa cuatro quesos (ingredientes)", 100, "Fideos con salsa cuatro quesos (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 10,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Noquis con Salsa Bolognesa (ingredientes)", "Noquis con Salsa Bolognesa", 100, "Noquis con Salsa Bolognesa (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 11,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Sorrentinos con Salsa Filetto (ingredientes)", 100, "Sorrentinos con Salsa Filetto (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 12,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Provoleta (ingredientes)", 100, "Provoleta (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 13,
                columns: new[] { "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "Parrillada para 1 (ingredientes)", 100, "Parrillada para 1 (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 14,
                columns: new[] { "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "Parrillada para 2 (ingredientes)", 100, "Parrillada para 2 (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 15,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Muzzarella (ingredientes)", 100, "Muzzarella (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 16,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Napolitana (ingredientes)", 100, "Napolitana (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 17,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Roquefort (ingredientes)", "Roquefort", 100, "Roquefort (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 18,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Fugazetta Rellena (ingredientes)", 100, "Fugazetta Rellena (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 19,
                columns: new[] { "Imagen", "Ingredientes", "Precio", "Preparacion" },
                values: new object[] { "url", "Hamburguesa (ingredientes)", 100, "Hamburguesa (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 20,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "url", "Pollo Cesar (ingredientes)", "Pollo Cesar", 100, "Pollo Cesar (preparacion)", 6 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 21,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "url", "Lechuga y Cebolla (ingredientes)", "Lechuga y Cebolla", 100, "Lechuga y Cebolla (preparacion)", 7 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 22,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Agua (ingredientes)", "Agua", 100, "Agua (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 23,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Agua con Gas (ingredientes)", "Agua con Gas", 100, "Agua con Gas (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 24,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "CocaCola (ingredientes)", "CocaCola", 100, "CocaCola (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 25,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Agua Tonica (ingredientes)", "Agua Tonica", 100, "Agua Tonica (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 26,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "url", "Vino (ingredientes)", "Vino", 100, "Vino (preparacion)", 8 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 27,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Blonde (ingredientes)", "Blonde", 100, "Blonde (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 28,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Honey (ingredientes)", "Honey", 100, "Honey (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 29,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { "url", "IPA (ingredientes)", "IPA", 100, "IPA (preparacion)", 9 });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 30,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Budin de Pan (ingredientes)", "Budin de Pan", 100, "Budin de Pan (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 31,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Copa Helada (ingredientes)", "Copa Helada", 100, "Copa Helada (preparacion)" });

            migrationBuilder.UpdateData(
                table: "Mercaderia",
                keyColumn: "MercaderiaId",
                keyValue: 32,
                columns: new[] { "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion" },
                values: new object[] { "url", "Panqueques con Dulce de Leche (ingredientes)", "Panqueques con Dulce de Leche", 100, "Panqueques con Dulce de Leche (preparacion)" });

            migrationBuilder.InsertData(
                table: "Mercaderia",
                columns: new[] { "MercaderiaId", "Imagen", "Ingredientes", "Nombre", "Precio", "Preparacion", "TipoMercaderiaId" },
                values: new object[] { 33, "url", "Frutilla con Crema (ingredientes)", "Frutilla con Crema", 100, "Frutilla con Crema (preparacion)", 10 });
        }
    }
}
