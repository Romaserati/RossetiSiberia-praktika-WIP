﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RossetiSiberia.DataAccess.Data;

#nullable disable

namespace RossetiSiberia.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240530182115_AddImageUrlColumnIntoDatabase")]
    partial class AddImageUrlColumnIntoDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RossetiSiberia.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Подключение к электросетям"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Потребление и учет электроэнергии"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Дополнительные услуги"
                        });
                });

            modelBuilder.Entity("RossetiSiberia.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Технологическое присоединение энергопринимающих устройств физических лиц до 15 кВт по одному источнику для бытовых нужд",
                            ImageUrl = "",
                            Name = "Технологическое присоединение энергопринимающих устройств физических лиц мощностью до 15 кВт"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Технологическое присоединение энергопринимающих устройств потребителей электрической энергии",
                            ImageUrl = "",
                            Name = "Технологическое присоединение энергопринимающих устройств"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Технологическое присоединение объектов микрогенерации, в том числе одновременно с энергопринимающим устройством",
                            ImageUrl = "",
                            Name = "Технологическое присоединение объектов микрогенерации"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Технологическое присоединение объектов, генерирующих электрическую энергию (за исключением объектов микрогенерации)",
                            ImageUrl = "",
                            Name = "Технологическое присоединение объектов по производству электрической энергии"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Технологическое присоединение объектов электросетевого хозяйства сетевой организации к электрическим сетям",
                            ImageUrl = "",
                            Name = "Технологическое присоединение объектов электросетевого хозяйства"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "Восстановление (переоформление) документов о технологическом присоединении",
                            ImageUrl = "",
                            Name = "Восстановление (переоформление) документов ТП"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "Перераспределение (снижение) мощности присоединенных энергопринимающих устройств",
                            ImageUrl = "",
                            Name = "Перераспределение (снижение) мощности"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Выполнение электромонтажных работ, связанных с установкой прибора учета электрической энергии",
                            ImageUrl = "",
                            Name = "Возмездная установка прибора учета"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "Осуществление работ по Установке или Замене ПУ 522",
                            ImageUrl = "",
                            Name = "Установка/замена прибора учета по ФЗ-522"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Description = "Выполнение электромонтажных работ, связанных с заменой прибора учета электрической энергии",
                            ImageUrl = "",
                            Name = "Возмездная замена прибора учета"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Description = "Выполнение работ по допуску в эксплуатацию прибора учета электрической энергии",
                            ImageUrl = "",
                            Name = "Допуск в эксплуатацию прибора учета"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Направление в адрес сетевой организации показаний прибора учета потребителя услуг",
                            ImageUrl = "",
                            Name = "Подача показаний прибора учета"
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Снятие показаний прибора учета сотрудником выбранной сетевой организации",
                            ImageUrl = "",
                            Name = "Снятие показаний прибора учета"
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Description = "Переустройство (вынос, перенос) электросетевых объектов сетевой организации в интересах потребителя",
                            ImageUrl = "",
                            Name = "Переустройство электросетевых объектов"
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Description = "Подготовка и выдача технических условий на размещение волоконно-оптических линий связи",
                            ImageUrl = "",
                            Name = "Технические условия на размещение линий связи"
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Description = "Мероприятия по техническому обслуживанию электросетевых объектов потребителя",
                            ImageUrl = "",
                            Name = "Техническое обслуживание электросетевых объектов"
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Description = "Аренда опор линии электропередачи, под модернизацию и строительства опор двойного назначения (ОДН)",
                            ImageUrl = "",
                            Name = "Опоры двойного назначения (ОДН)"
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Description = "Мероприятия по плановому ремонту, восстановлению работоспособности электросетевых объектов потребителя",
                            ImageUrl = "",
                            Name = "Ремонт электросетевых объектов"
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 3,
                            Description = "Осуществление работ по подбору, монтажу и техническому обслуживанию солнечной электростанции",
                            ImageUrl = "",
                            Name = "Солнечная станция «под ключ»"
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 3,
                            Description = "Осуществление работ по передаче объектов электросетевого хозяйства на баланс сетевой организации",
                            ImageUrl = "",
                            Name = "Передача объектов электросетевого хозяйства на баланс СО"
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 3,
                            Description = "Рассмотрение и согласование топографических съемок, планов и схем, а\r\nтакже рабочей и проектной документации.",
                            ImageUrl = "",
                            Name = "Рассмотрение и согласование документации"
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 3,
                            Description = "Оборудование и работы по установке оборудования для «Умного дома»",
                            ImageUrl = "",
                            Name = "Установка оборудования для «Умного дома»"
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 3,
                            Description = "Подготовка и выдача квалифицированных сертификатов электронной подписи.",
                            ImageUrl = "",
                            Name = "Квалифицированные сертификаты электронной подписи"
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 3,
                            Description = "Продажа, доставка и обслуживание дизель-генераторных установок",
                            ImageUrl = "",
                            Name = "Дизель-генераторные установки под ключ"
                        },
                        new
                        {
                            Id = 25,
                            CategoryId = 3,
                            Description = "Продажа, доставка, инжиниринг и проектирование источников бесперебойного питания",
                            ImageUrl = "",
                            Name = "Источники бесперебойного питания под ключ"
                        },
                        new
                        {
                            Id = 26,
                            CategoryId = 3,
                            Description = "Внутренние электромонтажные работы в индивидуальном жилом доме, квартире, офисе. ",
                            ImageUrl = "",
                            Name = "Внутренние электромонтажные работы "
                        },
                        new
                        {
                            Id = 27,
                            CategoryId = 3,
                            Description = "Комплексная услуга по установке, подключению и монтажу зарядных станций для дома и бизнеса",
                            ImageUrl = "",
                            Name = "Зарядные станции для электромобилей"
                        },
                        new
                        {
                            Id = 28,
                            CategoryId = 3,
                            Description = "Проектирование и строительно-монтажные работы по устройству архитектурно-художественной подсветки",
                            ImageUrl = "",
                            Name = "Организация архитектурно-художественной подсветки"
                        },
                        new
                        {
                            Id = 29,
                            CategoryId = 3,
                            Description = "Размещение наружного освещения на электросетевых объектах сетевой организации",
                            ImageUrl = "",
                            Name = "Размещение наружного освещения"
                        },
                        new
                        {
                            Id = 30,
                            CategoryId = 3,
                            Description = "Размещение на электросетевых объектах прочих конструкций и оборудования",
                            ImageUrl = "",
                            Name = "Размещение оборудования на электросетевых объектах"
                        },
                        new
                        {
                            Id = 31,
                            CategoryId = 3,
                            Description = "Аренда транспортных средств",
                            ImageUrl = "",
                            Name = "Аренда транспортных средств"
                        },
                        new
                        {
                            Id = 32,
                            CategoryId = 3,
                            Description = "Оперативно-техническое обслуживание сетей наружного освещения",
                            ImageUrl = "",
                            Name = "Техническое обслуживание наружного освещения"
                        },
                        new
                        {
                            Id = 33,
                            CategoryId = 3,
                            Description = "Ремонтно-эксплуатационное обслуживание сетей наружного освещения",
                            ImageUrl = "",
                            Name = "Ремонт наружного освещения"
                        },
                        new
                        {
                            Id = 34,
                            CategoryId = 3,
                            Description = "Испытание и диагностика электрооборудования, защитных средств и приборов",
                            ImageUrl = "",
                            Name = "Диагностика электрооборудования"
                        },
                        new
                        {
                            Id = 35,
                            CategoryId = 3,
                            Description = "Строительно-монтажные работы по устройству электрических сетей наружного освещения (пакетная услуга)",
                            ImageUrl = "",
                            Name = "Организация сетей наружного освещения"
                        },
                        new
                        {
                            Id = 36,
                            CategoryId = 3,
                            Description = "Проектно-изыскательские работы в целях строительства, реконструкции и перевооружения электросетевых объектов",
                            ImageUrl = "",
                            Name = "Проектно-изыскательские работы"
                        },
                        new
                        {
                            Id = 37,
                            CategoryId = 3,
                            Description = "Строительно-монтажные работы, реконструкция и перевооружение электросетевых объектов потребителя",
                            ImageUrl = "",
                            Name = "Строительно-монтажные работы"
                        },
                        new
                        {
                            Id = 38,
                            CategoryId = 3,
                            Description = "Технический надзор за производством строительно-монтажных работ",
                            ImageUrl = "",
                            Name = "Технический надзор за  СМР"
                        },
                        new
                        {
                            Id = 39,
                            CategoryId = 3,
                            Description = "Осуществление работ, отнесенных к компетенции заявителя при технологическом присоединении",
                            ImageUrl = "",
                            Name = "Выполнение технических условий на стороне клиента"
                        });
                });

            modelBuilder.Entity("RossetiSiberia.Models.Service", b =>
                {
                    b.HasOne("RossetiSiberia.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
