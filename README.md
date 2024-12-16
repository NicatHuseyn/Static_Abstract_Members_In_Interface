<h1>Static Abstract Members in Interface Nədir?</h1>
    <p>
      Static Abstract Member in İnterfaces-I başa düşə bilmək üçün əvvəlcə
      Static İnterface Member-lara baxmaq lazımdır.
      <br />
      Bilirik ki, interface-lər class-lara yol göstərən, başqa sözlə desək,
      class-ların imzalarını, içərisində olmasını məcburi edəcək strukturlardır.
      Bundan əlavə <strong>Default İmplementation</strong> özəlliyi ilə bu
      property-lərin gövdəsini də interfesylərdə saxlaya bilirik.
      <br />
      Bizlər bu <strong>Default İmplementation</strong> olaraq bəyan edilmiş
      member-ları həm də static olaraq da bəyan edə bilirik.
      <br />
      İnterfeyslərdə static member-ları bəyan edə bilmək üçün bu member-ları
      default implementation olaraq bəyan etməliyik.
    </p>
    <div style="width: 400px">
      <img src="https://github.com/user-attachments/assets/749b10a8-fb30-4ecc-a238-101d09d307ad" style="width: 400px" alt="" />
    </div>
    <p>Normalda interface içərisində static member yaza bilmərik.</p>
    <div style="width: 400px">
      <img src="https://github.com/user-attachments/assets/39598cf0-0afd-4fc4-82d0-b6a3b2a1fd48" style="width: 400px" alt="" />
    </div>

  <p>
      Amma Default Implementation ilə yazdıqda isə static olaraq bəyan edə
      bilirik.
      <br />
      İlk olaraq interface içərisindəki normal memeber və ya default
      implementation bəyanlarının compiler tərəfindən necə dəyərləndiriləcəyinə
      baxaq.
    </p>
    <div style="width: 400px">
      <img src="https://github.com/user-attachments/assets/05bda5d6-33b3-44f9-b83a-483f2f50cdd2" style="width: 400px" alt="" />
    </div>
    <p>
      Interface içərisində normal olaraq bəyan olunmuş hər hansı bir member
      <strong>(yəni DorWork())</strong>, abstract bir davranış göstərir.
    </p>
    <p>
      Oxşar şəkildə default implementation olaraq bəyan edilmiş bir member isə
      virtual olaraq bir davranış ortaya qoyacaqdır
      <strong>(yəni DoWork(string x){ })</strong>.
    </p>
    <p>
      <strong>
        Yəni, compiler tərəfdən bu member-lar bu şəkildə dəyərləndiriləcəkdir.
        Bu halda compiler-ın bu şəkildə dəyərləndirəcəyi member-ları istəsək,
        uyğun keyword-lərlə işarələyə bilərik. Aşağıdakı kimi
      </strong>
    </p>

  <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/8f9ad64e-1d18-40f1-ab28-cedbd44251a0" style="width: 600px" alt="" />
    </div>

  <p>
      Görüldüyü kimi A metodunu abstarct ilə də işarələyə bilirik, B metodu isə
      istəyə bağlıdır.
      <br />

  Yeri gəlmikən onu deyə bilərik ki, default implementation olan
      member-ların virtual olmasını istəmiriksə, sealed keyword-ü ilə
      işarələnməsi kifayyətdir.
    </p>
    <p>
      static keyword-ü ilə işarələnmiş default implementation member-lar isə özü
      etibarı ilə nə abstract-dır nə də virtual! Bu halda sealed ilə də
      işarələnməz! Lakin C# 11 ilə artıq static interface member-lar abstract
      keyword-ü işarələnə bilir və bu müəyyən davranışın sərgilənməsinə səbəb
      olacaq.
    </p>
    <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/3a53ae1e-8edc-4fc4-bc38-ad6883c2408e" style="width: 600px" alt="" />
    </div>
    <br />

  Yuxarıdakı koddan gördüyümüz kimi
    <ul>
      <li>Default İmplementation-ları static ilə işarələyə bilərik.</li>
      <li>Normal İmzaları static ilə işarələyə bilmirik!</li>
      <li>
        Normal imzaları static ilə işarələy bilmək üçün abstract ilə yazmalıyıq,
        yəni static abstract ilə işarələməliyik.
      </li>
    </ul>

  <div style="width: 800px">
      <img src="https://github.com/user-attachments/assets/50ce59f8-aede-4e5f-97e0-e130bb141a99" style="width: 800px" alt="" />
    </div>

  <h1>
      Okay bunlara baxdıq, gördük ki, belə bir özəllik var. İndi bir sual
      yaranır.
      <br />
      Bu Özəlliklər Bizim Nə İşimizə Yarıyajax?
    </h1>

  <p>
      Madam ki, yuxarıdaki kodlar static-dir, static member-ları bizlər referans
      vasitəsilə əldə edirik. AMMA
      <strong>static abstract member-lar da</strong> .(nöqtə) ilə gəlir,amma
      referans vasitəsilə əldə edə bilmərik, error verəcək!
    </p>

  <div style="width: 400px">
      <img src="https://github.com/user-attachments/assets/fb6db762-c9f5-44ec-8e4e-9d0f0baffb17" style="width: 400px" alt="" />
    </div>

  <p>
      Deməli başqa üsulla əldə etməliyik. Bəs necə?
      <br />
      Məhz bu interface-i implement edən class-ın instance-ı vasitəsilə edə
      bilərik. Yəni aşağıdakı Worker referansı vasitəsi ilə bu abstract static
      member-ları əldə edə bilərik.
    </p>

  <div style="width: 400px">
      <img src="https://github.com/user-attachments/assets/5285ac58-2a92-4866-8ab0-ec359b3dc266" style="width: 400px" alt="" />
    </div>
    <p>
      Uzun sözün qısası əlaqəli concrete class-ın referansı üzərindən əldə edə
      bilərik.
    </p>

  <br />
    <br />
    <p>
      <strong
        >Qısacası, static memberları interface-lər vasitəsilə hər hansı bir
        class-a məcburi implement etdirmək istəyiriksə, “Static Abstract
        Members” özəlliyini istifadə edə bilərik.
      </strong>
    </p>

  <h1>Static Abstract Members – Generic Type-larda</h1>

  <p>
      Madam ki, static abstract memberları sadəcə bir tip parametrindən əldə edə
      bilirik, bu zaman generic parametrlərdən də əldə edə bilməliyik.
    </p>

  <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/f2455124-4e23-44c4-a41d-8316a6fa43a2" style="width: 600px" alt="" />
    </div>
    <br />
    <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/731d9856-5796-4fec-97a8-9249d535a476" style="width: 600px" alt="" />
    </div>

  <p>
      Yuxarıdakı kimi istifadə edə bilirik. Amma burada adi static member-ları
      əldə edə bilməyəcəyik.
    </p>

  <p>
      İndi biz bu Worker class-ını istifadə edə bilmək üçün IWorker interfeysini
      implement etmiş olan bir tipə ehtiyacımız var. Məsələn aşağıdakı kimi
    </p>

  <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/abdf4302-6d36-48a2-b3c4-eaf89326596e" style="width: 600px" alt="" />
    </div>
    <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/b63b1435-5f3e-444d-a33a-4bbe8d6e7225" style="width: 600px" alt="" />
    </div>

  <h1>Static Abstract Operatorların Generic Parametrlərdəki Rolu</h1>

  <p>
      Static Abstract Member özəlliyi sayəsində interface-lərdə operator
      imzalarını bəyan edərək concrete class-lara məcburi olaraq operator
      overloading əməliyyatını həyata keçirir.
    </p>

  <div style="width: 800px">
      <img src="https://github.com/user-attachments/assets/f95084aa-69db-41bc-9b53-9b6103d1f1bf" style="width: 800px" alt="" />
    </div>
    <br />
    <div style="width: 800px">
      <img src="https://github.com/user-attachments/assets/a86905a9-d52d-4c6f-902f-7109df868afc" style="width: 800px" alt="" />
    </div>

  <p>
      Görüldüyü kimi yuxarıdakı nümunlərdəki kimi interfca içərisində bəyanat
      edə bilər və class-lara implement edə bilərik.
    </p>
    <p>
      Öyərndik ki, static abstract member-i ancaq class referansı ilə əldə edə
      bilərik. Halbuki burada operator bəyanatı etmişik və operatorlar obyekt
      olmadan bir məna ifadə etmirlər. Operatorlar funksionallıqlarını, operativ
      aktuallığını obyektdən alırlar, yəni burada təkçə refernas yox, obyektə də
      ehtiyacımız olacaq.
    </p>
    <p>
      İnterfaca-lər içərisində static member olaraq bəyan edilmiş olan operator
      imzalarının generic parametrlərdə mənaları vardır. Bu özəllik sayəsində
      bizlər generic parametrlər üzərində işlərimizi görə bilirik.
    </p>

  <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/52733e71-33e1-48dc-b82e-8338c07fe60d" style="width: 600px" alt="" />
    </div>

  <p>
      Görüldüyü kimi generic tiplərdə aşağıdakı kimi istifadə edə bilirik.
      <br />
      Bəs T-ə qarşılıq gələcək tip hansıdır?
      <br />
      T-ə qarşılıq isə Test class-ının özü olacaqdır.
    </p>

  <div style="width: 500px">
      <img src="https://github.com/user-attachments/assets/194987e4-de5a-4f94-9c11-7b14ec36a28e" style="width: 500px" alt="" />
    </div>

  <p>
      Biz burada t1 ilə t2 arasında 2 dənə ITest arasında toplama əməliyyatı
      edəndə bunun aktual operativ davranışını, İTest interfeysini implement
      edən concrete class-larla ifadə edəcəyik.
    </p>

   <h1>Static Abstract Operatorların Explicit və İmplicit İmplementation-ı</h1>

  <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/2ad6ef7a-233e-41f9-82fa-e76be6e41619" style="width: 600px" alt="" />
    </div>
    <br />
    <div style="width: 600px">
      <img src="https://github.com/user-attachments/assets/05914753-d0f7-4032-8805-e26d89031d8c" style="width: 600px" alt="" />
    </div>

   <h1>Static Abstract Members Özəlliyi Haralarda İstifadə Edilir?</h1>
    <p>
      Static Abstract Members özəlliyi, adətən generic parametrlərdəki
      bilinməzlik halları üçün uyğundur.
    </p>
    <p>
      Məsələn, arithmetic əməliyyatlar üçün System.Runtime.Experimental
      namespace-I altındakı INumber interfeysini incələyə bilərlər.
    </p>
    <p>
      Başa düşəcəyimiz kimi generic strukturlar üzərində static dəyərləri əldə
      etməyimiz lazım olan hallarda static abstract members özəlliyi köməyimizə
      çatır.
    </p>
