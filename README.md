# c-sharp_project_warehouse
Проєкт з c# 3 семестр, група ТА-03 Гуменюк, Гриценко.
Тема проєкту: Склад	    
По мірі обростання коду новими класами, буду їх описувати...
Клас Person, є батьківським для \о класу Chief.
Клас Chief має у собі : Stack<Materials>, Queue<Food>. 
Клас Item, є батьківським для класу: Food, Materials.
Клас mini_warehouses, містить у собі warehouse_for_food & warehouse_for_materials
Чимось кардинальним вони, між собою не відрізняються (тільки зберігають вони різні типи даних, ось і вся різниця)
Клас OurException, містить похідні класи від Exception
у основній формі - OurWarehouse, є такий статичний клас Date - потрібний для зберігання проміжних об'єктів
, таких як: різні списки, хеш-лист, сортований лист, словник.
 форми AddFood & AddMaterials делегують між собою задачу додавання до складу різних об'єктів, з їх назв, можна зрозуміти, які саме вони об'єкти вони додають. 
Форма RegistrationChief створена для того, щоб зареєструвати нашого chief - керивника складу. У цій же формі, використовується івент ChiefTransferEventArg для передавання інформації, з цієї форми до основної.

