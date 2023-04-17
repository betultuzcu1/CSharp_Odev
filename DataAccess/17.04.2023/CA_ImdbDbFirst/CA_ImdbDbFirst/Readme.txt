--IMDB Film Console Projesi--

--Klasörler
	-Models: Veritabanının yansımasını barındıran klasördür. İçerisinde Dbset ve class'lar bulunmaktakdır. Veritabanı'nın örneğini (instance) almak için Context nesnesinden bu instance alınmaası gerekmektedir.

	-ConsoleSpec: Program.cs içerisindeki main metodunda kullanılması için tanımlanan methodları barındırır. Kodlarımız daha anlaşılır ve geliştirebilinir olması için ayrı bir class içerisine alınarak sorumluluklarına göre işlemler ayrılmıştır.

	-Repository
		-Abstract: İçerisinde soyut (abstract) nesnelerin bulunduğu klasördür. Interface ve abstract gibi classları barındırmakla yükümlüdür. Her bir class'da olması gereken metotlar bu klasör içerisinde bulunan IMovieRepository'de barınacak.

		-Concrete: Soyut class (nesne) ların somut hale dönüştürüldüğü klasördür. İçerisinde Interface'den türetilen classlar barındırılır.