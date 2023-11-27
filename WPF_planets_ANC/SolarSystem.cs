﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
namespace NewListBox
{
    public class SolarSystem
    {
        // объявление коллекции динамических данных ObservableCollection<SolarSystemObject> и заполнение коллекции элементами
        private ObservableCollection<SolarSystemObject> solarSystemObjects;
        public ObservableCollection<SolarSystemObject> SolarSystemObjects //Свойство для работы с коллекцией элементов
        {
            get { return solarSystemObjects; }
        }
        public SolarSystem()
        {
            this.solarSystemObjects = new
            ObservableCollection<SolarSystemObject>();
            /* Добавляем новые объекты типа SolarSystemObject(Название, число:
            удаление от солнца [а. е.], число: средний диаметр [км], ссылка на
            изображение внутри проекта, описание) */
            this.solarSystemObjects.Add(new SolarSystemObject("Солнце", 0, 1380000, new Uri(@"Planets\Sun.jpg", UriKind.Relative), "Со́лнце — единственная звезда Солнечной системы, вокруг которой обращаются другиеобъекты этой системы: планеты и их спутники, карликовые планеты и ихспутники, астероиды, метеороиды, кометы и космическая пыль."));
            this.solarSystemObjects.Add(new SolarSystemObject("Меркурий", 0.38, 4880, new Uri(@"Planets\Mercury.jpg", UriKind.Relative), "Мерку́рий — самаяблизкая к Солнцу планета Солнечной системы, обращающаяся вокруг Солнца за 88 земных суток."));
            this.solarSystemObjects.Add(new SolarSystemObject("Венера", 0.72, 12103.6, new Uri(@"Planets\Venus.jpg", UriKind.Relative), "Вене́ра — вторая внутренняя планета Солнечной системы с периодом обращения в 224, 7 земных суток.Планета получила своё название в честь Венеры, богини любви из римского пантеона.Венера — третий по яркости объект на небе Земли после Солнца и Луны и достигает видимой звёздной величины в −4, 6."));
            this.solarSystemObjects.Add(new SolarSystemObject("Земля", 1, 12756.3, new Uri(@"Planets\Earth.jpg", UriKind.Relative), "Земля́ — третья от Солнца планета Солнечной системы, крупнейшая по диаметру, массе и плотности среди планет земной группы.Наша родная планета."));
            this.solarSystemObjects.Add(new SolarSystemObject("Марс", 1.52, 6794, new Uri(@"Planets\Mars.jpg", UriKind.Relative), "Марс — четвёртая по удалённости от Солнца и седьмая по размерам планета Солнечной системы; масса планеты составляет 10,7 % массы Земли."));
            this.solarSystemObjects.Add(new SolarSystemObject("Юпитер", 5.20, 142984, new Uri(@"Planets\Jupiter.jpg", UriKind.Relative), "Юпи́тер — пятая планета от Солнца, крупнейшая в Солнечной системе.Наряду с Сатурном, Ураном и Нептуном Юпитер классифицируется как газовый гигант.Планета была известна людям с глубокой древности, что нашло своё отражение в мифологии и религиозных верованиях различных культур: месопотамской, вавилонской, греческой и других.Современное название Юпитера происходит от имени древнеримского верховного бога - громовержца."));
            this.solarSystemObjects.Add(new SolarSystemObject("Сатурн", 9.54, 120536, new Uri(@"Planets\Saturn.png", UriKind.Relative), "Сату́рн — шестая планета от Солнца и вторая по размерам планета в Солнечной системе после Юпитера.Сатурн, а также Юпитер, Уран и Нептун, классифицируются как газовые гиганты.Сатурн назван в честь римского бога земледелия."));
            this.solarSystemObjects.Add(new SolarSystemObject("Уран", 19.218, 51118, new Uri(@"Planets\Uranus.jpg", UriKind.Relative), "Ура́н — седьмая по удалённости от Солнца, третья по диаметру и четвёртая по массе планета Солнечной системы.Была открыта в 1781 году английским астрономом Уильямом Гершелем и названа в честь греческого бога неба Урана, отца Кроноса(в римской мифологии Сатурна) и, соответственно, деда Зевса."));
            this.solarSystemObjects.Add(new SolarSystemObject("Нептун", 30.06, 49532, new Uri(@"Planets\Neptune.jpg", UriKind.Relative), "Непту́н — восьмая и самая дальняя планета Солнечной системы. Нептун также является четвёртой по диаметру и третьей по массе планетой.Масса Нептуна в 17, 2 раза, а диаметр экватора в 3, 9 раза больше таковых у Земли.Планета была названа в честь римского бога морей."));
            this.solarSystemObjects.Add(new SolarSystemObject("Плутон", 39.5, 2274, new Uri(@"Planets\Pluto.jpg", UriKind.Relative), "Плуто́н (134340 Pluto) — крупнейшая по размерам, наряду с Эридой, карликовая планета Солнечной системы, транснептуновый объект(ТНО) и девятое / десятое по величине небесное тело, обращающееся вокруг Солнца.Первоначально Плутон классифицировался как планета, однако сейчас он считается одним из крупнейших объектов(возможно, самым крупным) в поясе Койпера."));
        }
    }
}