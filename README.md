### Design Pattern

* Bu proje ile 11 farklı tasarım kalıbı uygulaması seti oluşturulmuştur..Her bir desen, gerçek dünyada karşılaşılan yazılım tasarım 
problemlerine çözümler sunmak, daha esnek ve sürdürülebilir olmasını sağlamak amacı ile, gerçek dünyadan problemler üzerine geliştirilmiştir.
Proje sayesinde, tasarım desenlerin iş mantığını ve nasıl uygulanabileceğini göstermek,yazılım geliştiricilere pratik bir referans sunmak amacıyla oluşturulmuştur.

## ℹ️ Tasarım Kalıpları

#### 1. Chain Of Responsibility Design Pattern
Chain of Responsibility deseni, isteklerin bir zincir boyunca işlenmesini sağlar. Her nesne bir işleyici (handler) olarak görev yapar ve isteği işleyebilir ya da 
zincirin bir sonraki halkasına iletebilir. Bu desen, işlemi gerçekleştirecek uygun nesnenin seçilmesini dinamik olarak sağlar.

![chain-of-responsibility](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/4e0495d2-7920-4a0d-86f4-10cf7748ab9f)


### 2.Command Query Responsibility Sagregation Design Pattern
Komutların (Yazma) ile sorguların (Okuma) işlemlerinin farklı modeller kullanılarak ayrılmasını ön gören tasarım desenidir. Bu ayrım, sistemin okuma ve yazma işlemlerini ayrı ayrı optimize 
etmeyi mümkün kılar.

![command-en](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/1825801e-8485-4b08-9900-84297a902a19)


### 3. Template Method Design Pattern
Bir işlemin iskeletini tanımlayan ve alt sınıfların bu iskeleti kullanarak belirli adımlarını özelleştirmelerine olanak tanıyan tasarım desenidir.Bu sayede,belirli işlemlerin nasıl gerçekleştirileceğine
dair detayları alt sınıflara devrederek,iskeletin genel yapısını sabit tutar.Bu,kod tekrarını azaltarak, ortak davranışların merkezi bir yerde toplanmasını sağlar ve alt sınıfların yalnızca değişen
ceya spesifik davranışları uygulamasına olanak sağlar.
  
![template-method](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/1d2118ea-75db-4b73-9d2f-36be513fedde)


### 4. Observer Design Pattern
Bir nesnenin durumundaki değişiklikleri izleyen ve bu değişiklikleri kendi durumlarına yansıtan bir tasarım desenidir.Bu desen, ana nesnenin durumundaki değişiklikleri izleyen birden fazla nesne
arasındaki bağımlılığı azaltır,böylece ana nesnenin durum değişikliklerine dinamik bir şekilde tepki verilmesini sağlar.

![observer](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/d1016b0e-b4d3-46c1-a274-345612d8fb7b)


### 5. Unit Of Work Design Pattern
Veri tabanı işlemlerini bir arada toplar ve hepsini tek bir işlem (transaction) olarak yönetir. 
Bu desen, birim içerisindeki işlemlerin tümünün başarılı olması durumunda veritabanına yazılmasını, aksi halde hiçbir işlemin gerçekleştirilmemesini sağlar

![memento (1)](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/39177945-979f-47b3-9cf6-d440855a6213)


### 6. Repository Design Pattern
Bu desen, bir veritabanı nesnesine erişim sağlayan bir arayüz sağlar ve bu arayüzü kullanan sınıfların veritabanı işlemlerini gerçekleştirmesini sağlar. 
Bu, veri erişimi kodunun tekrar kullanılabilirliğini artırır ve bakımını kolaylaştırır.


### 7. Composite Design Pattern
Composite deseni, "bir bütün ve parçaları" ilişkisini temsil eder. Bu desen, bir nesnenin içinde diğer nesneleri içerebileceği ve bu nesnelerin gruplarını
oluşturabileceği bir yapı sağlar. Böylece, tekil nesneler ve bu nesnelerin grupları aynı şekilde ele alınabilir. Composite deseni, özellikle aynı arayüzü uygulayan ve benzer davranışlar sergileyen
nesnelerin gruplarını yönetmek için kullanıldığında  faydalıdır. Bu desen, kod tekrarını azaltır, bakımı kolaylaştırır ve genişletilebilirlik sağlar.

![composite](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/afde4a23-9c80-4976-9036-a6e6e3acfe12)


### 8. Mediator Design Pattern
Arabulucu : Nesneler arasındaki iletişimi kendisi üstlenir. Böylece sınıflar birbiri ile haberleşmek yerine tek bir merkez ile haberleşir. 

![mediator](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/9cf41b15-501f-4873-aa80-1423c612e71a)


### 9. Iterator Design Pattern
Taşıyıcı görevini üstlenir.Iterator, bir koleksiyonun elemanlarına sırayla erişimi sağlayan ve bu erişimi standartlaştıran bir tasarım desenidir. 
Bu desen, bir koleksiyonun içindeki elemanlara teker teker erişmeyi ve bu elemanlar üzerinde dolaşmayı kolaylaştırır.

![iterator-en](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/0d9ed38f-eb95-4f36-ae9d-2ca66f68dd1f)


### 10. Facade Design Pattern
Facade, bir alt sistemdeki karmaşık işlemleri basitleştiren ve dış dünyaya tek bir arayüz sağlayan bir tasarım desenidir.
Bu desen, birbirleriyle bağlantılı olan alt sistemlerin karmaşıklığını gizler ve istemciye daha basit bir arayüz sunar.

![facade](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/c6033ce8-6c9f-4c25-9864-4fb227c6fe8f)


### 11. Decorator Design Pattern
Decorator, bir nesneye dinamik olarak ek özellikler ekleyen ve böylece nesnenin davranışını değiştiren bir tasarım desenidir.
Bu desen, bir nesneyi sarmalayan ve bu nesneye ek işlevselliği ekleyen dekoratör sınıflarının kullanılmasını sağlar.

![decorator](https://github.com/gozgirfaruk/DesignPatterns/assets/125920944/f143b5b2-9514-4c8e-a335-9110b25930d3)










  
