﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RossetiSiberia.Models;

namespace RossetiSiberia.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Подключение к электросетям" },
                new Category { Id = 2, CategoryName = "Потребление и учет электроэнергии" },
                new Category { Id = 3, CategoryName = "Дополнительные услуги" }
                );

            modelBuilder.Entity<Service>().HasData(
                new Service
                {
                    Id = 1,
                    Name = "Технологическое присоединение энергопринимающих устройств физических лиц мощностью до 15 кВт",
                    CategoryId = 1,
                    Description = "Технологическое присоединение энергопринимающих устройств физических лиц до 15 кВт по одному источнику для бытовых нужд"
                },
                new Service
                {
                    Id = 2,
                    Name = "Технологическое присоединение энергопринимающих устройств",
                    CategoryId = 1,
                    Description = "Технологическое присоединение энергопринимающих устройств потребителей электрической энергии"
                },
                new Service
                {
                    Id = 3,
                    Name = "Технологическое присоединение объектов микрогенерации",
                    CategoryId = 1,
                    Description = "Технологическое присоединение объектов микрогенерации, в том числе одновременно с энергопринимающим устройством"
                },
                new Service
                {
                    Id = 4,
                    Name = "Технологическое присоединение объектов по производству электрической энергии",
                    CategoryId = 1,
                    Description = "Технологическое присоединение объектов, генерирующих электрическую энергию (за исключением объектов микрогенерации)"
                },
                new Service 
                {
                    Id = 5,
                    Name = "Технологическое присоединение объектов электросетевого хозяйства",
                    CategoryId = 1,
                    Description = "Технологическое присоединение объектов электросетевого хозяйства сетевой организации к электрическим сетям"
                },
                new Service 
                {
                    Id = 6,
                    Name = "Восстановление (переоформление) документов ТП",
                    CategoryId = 1,
                    Description = "Восстановление (переоформление) документов о технологическом присоединении"
                },
                new Service 
                {
                    Id = 7,
                    Name = "Перераспределение (снижение) мощности",
                    CategoryId = 1,
                    Description = "Перераспределение (снижение) мощности присоединенных энергопринимающих устройств"
                },
                new Service 
                {
                    Id = 8,
                    Name = "Возмездная установка прибора учета",
                    CategoryId = 2,
                    Description = "Выполнение электромонтажных работ, связанных с установкой прибора учета электрической энергии"
                },
                new Service 
                {
                    Id = 9,
                    Name = "Установка/замена прибора учета по ФЗ-522",
                    CategoryId = 2,
                    Description = "Осуществление работ по Установке или Замене ПУ 522"
                },
                new Service 
                {
                    Id = 10,
                    Name = "Возмездная замена прибора учета",
                    CategoryId = 2,
                    Description = "Выполнение электромонтажных работ, связанных с заменой прибора учета электрической энергии"
                },
                new Service 
                {
                    Id = 11,
                    Name = "Допуск в эксплуатацию прибора учета",
                    CategoryId = 2,
                    Description = "Выполнение работ по допуску в эксплуатацию прибора учета электрической энергии"
                },
                new Service 
                {
                    Id = 12,
                    Name = "Подача показаний прибора учета",
                    CategoryId = 2,
                    Description = "Направление в адрес сетевой организации показаний прибора учета потребителя услуг"
                },
                new Service 
                {
                    Id = 13,
                    Name = "Снятие показаний прибора учета",
                    CategoryId = 2,
                    Description = "Снятие показаний прибора учета сотрудником выбранной сетевой организации"
                },
                new Service 
                {
                    Id = 14,
                    Name = "Переустройство электросетевых объектов",
                    CategoryId = 3,
                    Description = "Переустройство (вынос, перенос) электросетевых объектов сетевой организации в интересах потребителя"
                },
                new Service 
                {
                    Id = 15,
                    Name = "Технические условия на размещение линий связи",
                    CategoryId = 3,
                    Description = "Подготовка и выдача технических условий на размещение волоконно-оптических линий связи"
                },
                new Service 
                {
                    Id = 16,
                    Name = "Техническое обслуживание электросетевых объектов",
                    CategoryId = 3,
                    Description = "Мероприятия по техническому обслуживанию электросетевых объектов потребителя"
                },
                new Service 
                {
                    Id = 17,
                    Name = "Опоры двойного назначения (ОДН)",
                    CategoryId = 3,
                    Description = "Аренда опор линии электропередачи, под модернизацию и строительства опор двойного назначения (ОДН)"
                },
                new Service 
                {
                    Id = 18,
                    Name = "Ремонт электросетевых объектов",
                    CategoryId = 3,
                    Description = "Мероприятия по плановому ремонту, восстановлению работоспособности электросетевых объектов потребителя"
                },
                new Service 
                {
                    Id = 19,
                    Name = "Солнечная станция «под ключ»",
                    CategoryId = 3,
                    Description = "Осуществление работ по подбору, монтажу и техническому обслуживанию солнечной электростанции"
                },
                new Service 
                {
                    Id = 20,
                    Name = "Передача объектов электросетевого хозяйства на баланс СО",
                    CategoryId = 3,
                    Description = "Осуществление работ по передаче объектов электросетевого хозяйства на баланс сетевой организации"
                },
                new Service 
                {
                    Id = 21,
                    Name = "Рассмотрение и согласование документации",
                    CategoryId = 3,
                    Description = "Рассмотрение и согласование топографических съемок, планов и схем, а\r\nтакже рабочей и проектной документации."
                },
                new Service 
                {
                    Id = 22,
                    Name = "Установка оборудования для «Умного дома»",
                    CategoryId = 3,
                    Description = "Оборудование и работы по установке оборудования для «Умного дома»"
                },
                new Service 
                {
                    Id = 23,
                    Name = "Квалифицированные сертификаты электронной подписи",
                    CategoryId = 3,
                    Description = "Подготовка и выдача квалифицированных сертификатов электронной подписи."
                },
                new Service 
                {
                    Id = 24,
                    Name = "Дизель-генераторные установки под ключ",
                    CategoryId = 3,
                    Description = "Продажа, доставка и обслуживание дизель-генераторных установок"
                },
                new Service 
                {
                    Id = 25,
                    Name = "Источники бесперебойного питания под ключ",
                    CategoryId = 3,
                    Description = "Продажа, доставка, инжиниринг и проектирование источников бесперебойного питания"
                },
                new Service 
                {
                    Id = 26,
                    Name = "Внутренние электромонтажные работы ",
                    CategoryId = 3,
                    Description = "Внутренние электромонтажные работы в индивидуальном жилом доме, квартире, офисе."
                },
                new Service 
                {
                    Id = 27,
                    Name = "Зарядные станции для электромобилей",
                    CategoryId = 3,
                    Description = "Комплексная услуга по установке, подключению и монтажу зарядных станций для дома и бизнеса"
                },
                new Service 
                {
                    Id = 28,
                    Name = "Организация архитектурно-художественной подсветки",
                    CategoryId = 3,
                    Description = "Проектирование и строительно-монтажные работы по устройству архитектурно-художественной подсветки"
                },
                new Service 
                {
                    Id = 29,
                    Name = "Размещение наружного освещения",
                    CategoryId = 3,
                    Description = "Размещение наружного освещения на электросетевых объектах сетевой организации"
                },
                new Service 
                {
                    Id = 30,
                    Name = "Размещение оборудования на электросетевых объектах",
                    CategoryId = 3,
                    Description = "Размещение на электросетевых объектах прочих конструкций и оборудования"
                },
                new Service 
                {
                    Id = 31,
                    Name = "Аренда транспортных средств",
                    CategoryId = 3,
                    Description = "Аренда транспортных средств"
                },
                new Service 
                {
                    Id = 32,
                    Name = "Техническое обслуживание наружного освещения",
                    CategoryId = 3,
                    Description = "Оперативно-техническое обслуживание сетей наружного освещения"
                },
                new Service 
                {
                    Id = 33,
                    Name = "Ремонт наружного освещения",
                    CategoryId = 3,
                    Description = "Ремонтно-эксплуатационное обслуживание сетей наружного освещения"
                },
                new Service 
                {
                    Id = 34,
                    Name = "Диагностика электрооборудования",
                    CategoryId = 3,
                    Description = "Испытание и диагностика электрооборудования, защитных средств и приборов"
                },
                new Service 
                {
                    Id = 35,
                    Name = "Организация сетей наружного освещения",
                    CategoryId = 3,
                    Description = "Строительно-монтажные работы по устройству электрических сетей наружного освещения (пакетная услуга)"
                },
                new Service 
                {
                    Id = 36,
                    Name = "Проектно-изыскательские работы",
                    CategoryId = 3,
                    Description = "Проектно-изыскательские работы в целях строительства, реконструкции и перевооружения электросетевых объектов"
                },
                new Service 
                {
                    Id = 37,
                    Name = "Строительно-монтажные работы",
                    CategoryId = 3,
                    Description = "Строительно-монтажные работы, реконструкция и перевооружение электросетевых объектов потребителя"
                },
                new Service 
                {
                    Id = 38,
                    Name = "Технический надзор за  СМР",
                    CategoryId = 3,
                    Description = "Технический надзор за производством строительно-монтажных работ"
                },
                new Service 
                {
                    Id = 39,
                    Name = "Выполнение технических условий на стороне клиента",
                    CategoryId = 3,
                    Description = "Осуществление работ, отнесенных к компетенции заявителя при технологическом присоединении"
                });
        }
    }
}
