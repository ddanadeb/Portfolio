<!DOCTYPE html>
<html>
<head>
<title></title>
</head>

<body>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Prirodna Kozmetika</title>
<div class="home">
    <div class="home__cover">
        <h1><i><b>Dobrodosli u prodavnicu Prirodne Kozmetike, uzivajte u kupovini</b></i></h1>
    </div>
</div>
<style>
	.divclass[home] {
		font-color: green;
	}
	</style>

<style>
	body {
	background-image: url("glavnaslika1.jpg");
	opacity:100%;
	background-image-width:100%;
}


</style>
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">

<link rel="stylesheet" type="text/css" href="css/index.css"></head>
<body>
<div class="cf">
<nav class="navbar navbar-default"><!-- Pocetak menija -->
<div class="container-fluid">
<!-- Brand and toggle get grouped for better mobile display -->
<div class="navbar-header">
<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
<span class="sr-only">Navigacija</span>
<span class="icon-bar"></span>
<span class="icon-bar"></span>
<span class="icon-bar"></span>
</button>
<a class="navbar-brand" href="index.php">Prirodna Kozmetika</a>
</div>

<!-- Collect the nav links, forms, and other content for toggling -->
<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
<ul class="nav navbar-nav">
<li><a href="shop.html">Prodavnica</a></li>
</ul>
<form class="navbar-form navbar-left">

</form>
<ul class="nav navbar-nav navbar-right">
<li><a href="korpa.php">Korpa</a></li>
</ul>
<ul class="nav navbar-nav navbar-right">
<li><a href="nalog.php">Nalog</a></li>
</ul>
</div><!-- /.navbar-collapse -->
</div><!-- /.container-fluid -->
</nav><!-- Kraj menija -->
<form action="checkout.php" method="post">
<?php include("konekcija.php") ?>

</form>
<footer> <!-- pocetak footera -->
<div class="row"> <!-- otvoren gridview -->
<div class="col-md-4">
<div class="page-header">
<h4><b> O nama </b></h4>
<p> <b> Prirodna Kozmetika se bavi online prodajom kozmetike koja po sastavu ispunjava uslove prirodne kozmetike i u našoj ponudi se može pronaći proizvod bilo kog brenda a jedini preduslov je odgovarajući sastav. Uz pomoć aplikacije INCI Beauty kreiranoj od strane farmaceuta jednostavnim skeniranjem bar-koda proveravamo da li je proizvod ispunio neophodne kriterijume. Aplikacija je bazirana na proveravanju sastava proizvoda pri čemu proizvodi sa štetnim sastojcima označenim crvenom bojom ne ulaze u našu ponudu. Želimo da ponudimo zdravije rešenje i zato je sastav ono što nas usmerava, a ne reklama ili opis proizvoda koji uvek izdvoji one prirodne sastojke a prikrije štetne. Dugotrajno rešenje za našu kožu i kosu može da bude samo ono pogodno i za naše zdravlje, prirodno i oslobođeno sastojaka kao što su parabeni, silikoni, sulfati, naftni derivati, formaldehidi i mnogi drugi sastojci. Pronalazak odgovarajućeg kozmetičkog proizvoda je za neke žene idalje neuspešna misija. Prepreke su ograničen izbor brendova u prodavnicama, visoke cene brendova koji nude bolje rešenje i neinformisanost o sastojcima. Mi izvlačimo ono najbolje iz svakog brenda </b> </p>
<h4><b>Kontakt</b> </h4>
</div>
<p class="text-justify"> <i class="fas fa-phone-alt"></i> <b> +381 63173897 </b> </p>
<p class="text-justify"> <i class="far fa-paper-plane"></i><b> prirodnakozmetika@gmail.com</b> </p>
</div>
</div>
<div class="col-md-4">
<div class="page-header">
</div>
<div class="col-md-4">
<div class="page-header">
</div>
</div>
</footer>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="js/bootstrap.min.js"></script>
</div>
</div>
</body>
</html>