# dotnet-core-web-api-article
Article.Web.API

<h3>Kullanılan Tasarım Desenleri</h3>

<ol>
  <li><b>Repository Pattern</b></li>
</ol>
<p>Kullanım nedeni : Her model için repository yazmak kod tekrarına neden olur. Bunun yerine abstract base repository oluşturup TModel generic türünü tanımlıyoruz.
Constructor’da ise MongoDB’ye bağlanma işlemlerini gerçekleştiriyoruz ve istediğimiz collection’ın getirilmesini sağlıyoruz.
Ekstra bir kod yazmadan Repository’nin CRUD işlemlerini yerine getirmesini sağlamış oluyoruz.
</p>

<h3>Kullanılan Teknolojiler ve Kütüphaneler</h3>
<ol>
<li>.Net Core</li>
  <p>Çalıştığım yerde .Net Framework kullanılmakta, fakat kişisel çalışmalarımda kullandığım kadarıyla tecrübem bulunmaktadır.</p>
<li>RESTful API</li>
  <p>Geliştirdiğimiz bir projede web servis RESTful olarak yazıldı.</p>
<li>MongoDB Drive</li>
  <p>RDBMS olarak MSSQL kullanıyoruz ayrıca kuyruk yapısında NoSQL olarak MongoDB kullanmaktayız. MongoDB'yi bu nedenle tercih ettim diyebilirim.</p>
<li>Git</li>
  <p>TFS kullanıyorduk yakın zamanda Git ile çalışmaya başladık.</p>
</ol>

<h3>Projeye Eklemek İstediklerim</h3>
<p>Authentication işlemi (örn. Token Based), cross-origin, </p>
<p>Dönülecek response değerler ve bu değerlere göre alınacak aksiyonlar,</p>
<p>Farklı veri tipleri ile HttpGet ile veri getirmek,</p>
<p>Exception yönetimi,</p>
<p>İstekleri ve sonuçları loglamak,</p>
<p>Unit Test</p>
