using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RossetiSiberia.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addForeignKeyForCategoryServiceRelationAndSeedServiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Технологическое присоединение энергопринимающих устройств физических лиц до 15 кВт по одному источнику для бытовых нужд", "Технологическое присоединение энергопринимающих устройств физических лиц мощностью до 15 кВт" },
                    { 2, 1, "Технологическое присоединение энергопринимающих устройств потребителей электрической энергии", "Технологическое присоединение энергопринимающих устройств" },
                    { 3, 1, "Технологическое присоединение объектов микрогенерации, в том числе одновременно с энергопринимающим устройством", "Технологическое присоединение объектов микрогенерации" },
                    { 4, 1, "Технологическое присоединение объектов, генерирующих электрическую энергию (за исключением объектов микрогенерации)", "Технологическое присоединение объектов по производству электрической энергии" },
                    { 5, 1, "Технологическое присоединение объектов электросетевого хозяйства сетевой организации к электрическим сетям", "Технологическое присоединение объектов электросетевого хозяйства" },
                    { 6, 1, "Восстановление (переоформление) документов о технологическом присоединении", "Восстановление (переоформление) документов ТП" },
                    { 7, 1, "Перераспределение (снижение) мощности присоединенных энергопринимающих устройств", "Перераспределение (снижение) мощности" },
                    { 8, 2, "Выполнение электромонтажных работ, связанных с установкой прибора учета электрической энергии", "Возмездная установка прибора учета" },
                    { 9, 2, "Осуществление работ по Установке или Замене ПУ 522", "Установка/замена прибора учета по ФЗ-522" },
                    { 10, 2, "Выполнение электромонтажных работ, связанных с заменой прибора учета электрической энергии", "Возмездная замена прибора учета" },
                    { 11, 2, "Выполнение работ по допуску в эксплуатацию прибора учета электрической энергии", "Допуск в эксплуатацию прибора учета" },
                    { 12, 2, "Направление в адрес сетевой организации показаний прибора учета потребителя услуг", "Подача показаний прибора учета" },
                    { 13, 2, "Снятие показаний прибора учета сотрудником выбранной сетевой организации", "Снятие показаний прибора учета" },
                    { 14, 3, "Переустройство (вынос, перенос) электросетевых объектов сетевой организации в интересах потребителя", "Переустройство электросетевых объектов" },
                    { 15, 3, "Подготовка и выдача технических условий на размещение волоконно-оптических линий связи", "Технические условия на размещение линий связи" },
                    { 16, 3, "Мероприятия по техническому обслуживанию электросетевых объектов потребителя", "Техническое обслуживание электросетевых объектов" },
                    { 17, 3, "Аренда опор линии электропередачи, под модернизацию и строительства опор двойного назначения (ОДН)", "Опоры двойного назначения (ОДН)" },
                    { 18, 3, "Мероприятия по плановому ремонту, восстановлению работоспособности электросетевых объектов потребителя", "Ремонт электросетевых объектов" },
                    { 19, 3, "Осуществление работ по подбору, монтажу и техническому обслуживанию солнечной электростанции", "Солнечная станция «под ключ»" },
                    { 20, 3, "Осуществление работ по передаче объектов электросетевого хозяйства на баланс сетевой организации", "Передача объектов электросетевого хозяйства на баланс СО" },
                    { 21, 3, "Рассмотрение и согласование топографических съемок, планов и схем, а\r\nтакже рабочей и проектной документации.", "Рассмотрение и согласование документации" },
                    { 22, 3, "Оборудование и работы по установке оборудования для «Умного дома»", "Установка оборудования для «Умного дома»" },
                    { 23, 3, "Подготовка и выдача квалифицированных сертификатов электронной подписи.", "Квалифицированные сертификаты электронной подписи" },
                    { 24, 3, "Продажа, доставка и обслуживание дизель-генераторных установок", "Дизель-генераторные установки под ключ" },
                    { 25, 3, "Продажа, доставка, инжиниринг и проектирование источников бесперебойного питания", "Источники бесперебойного питания под ключ" },
                    { 26, 3, "Внутренние электромонтажные работы в индивидуальном жилом доме, квартире, офисе. ", "Внутренние электромонтажные работы " },
                    { 27, 3, "Комплексная услуга по установке, подключению и монтажу зарядных станций для дома и бизнеса", "Зарядные станции для электромобилей" },
                    { 28, 3, "Проектирование и строительно-монтажные работы по устройству архитектурно-художественной подсветки", "Организация архитектурно-художественной подсветки" },
                    { 29, 3, "Размещение наружного освещения на электросетевых объектах сетевой организации", "Размещение наружного освещения" },
                    { 30, 3, "Размещение на электросетевых объектах прочих конструкций и оборудования", "Размещение оборудования на электросетевых объектах" },
                    { 31, 3, "Аренда транспортных средств", "Аренда транспортных средств" },
                    { 32, 3, "Оперативно-техническое обслуживание сетей наружного освещения", "Техническое обслуживание наружного освещения" },
                    { 33, 3, "Ремонтно-эксплуатационное обслуживание сетей наружного освещения", "Ремонт наружного освещения" },
                    { 34, 3, "Испытание и диагностика электрооборудования, защитных средств и приборов", "Диагностика электрооборудования" },
                    { 35, 3, "Строительно-монтажные работы по устройству электрических сетей наружного освещения (пакетная услуга)", "Организация сетей наружного освещения" },
                    { 36, 3, "Проектно-изыскательские работы в целях строительства, реконструкции и перевооружения электросетевых объектов", "Проектно-изыскательские работы" },
                    { 37, 3, "Строительно-монтажные работы, реконструкция и перевооружение электросетевых объектов потребителя", "Строительно-монтажные работы" },
                    { 38, 3, "Технический надзор за производством строительно-монтажных работ", "Технический надзор за  СМР" },
                    { 39, 3, "Осуществление работ, отнесенных к компетенции заявителя при технологическом присоединении", "Выполнение технических условий на стороне клиента" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Services",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Categories_CategoryId",
                table: "Services",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}
