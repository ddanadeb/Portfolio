	<div class="wrapper">
		<section>

			<?php 

			$mysqli = new mysqli("localhost", "root", "", "prirodnakozmetika1");

			if (isset($_GET['error'])) {
				if ($_GET['error'] == "emtyfields") {
					echo '<p class="signuperror>Popunite sva polja!</p>';
				}
				else if ($_GET['error'] == "invalidemailuid") {
					echo '<p class="signuperror">Unesite validan E-mail i Username!</p>';
				}
				else if ($_GET['error'] == "invalidemail") {
					echo '<p class="signuperror">Unesite validan E-mail!</p>';
				}
				else if ($_GET['error'] == "invaliduid") {
					echo '<p class="signuperror">Unesite validan Username!</p>';
				}
				else if ($_GET['error'] == "passwordCheck") {
					echo '<p class="signuperror">Lozinke se ne poklapaju!</p>';
				}
				else if ($_GET['error'] == "usertaken") {
					echo '<p class="signuperror">Username je zauzet!</p>';
				}
				else if ($_GET['error'] == "usertaken") {
					echo '<p class="signuperror">Username je zauzet!</p>';
				}
			}
			if (isset($_GET['signup'])){
				if ($_GET['signup'] == "success") {
					echo '<p class="signuperror">Uspesno obavljeno!</p>';
				}
			}
			?>
			<form class="form-signup" method="post" action="nalog.php">
				<div><input required type="text" name="uid" placeholder="Username"></div>
				<div><input required type="email" name="mail" placeholder="E-mail"></div>
				<div><input required type="password" name="pwd" placeholder="Password"></div>
				<div><input required type="password" name="pwd-repeat" placeholder="Repeat password"></div>
				<div><button type="submit" name="signup-submit"><b>SignUp</b></button>	</div>	
			</form>
		</section>
	</div>
</div>
<div class="home">
	<div class="home__cover">
		<?php 

		

		if (!(isset($_SESSION['login']))) {
			echo "
			<form class='form-signup' action='nalog.php' method='post'>
			<div><input type='text' name='username' placeholder='Username/E-mail...'></div>
			<div><input type='password' name='password' placeholder='Password'></div>
			<div><button type='submit' name='login-submit'>LogIn</button></div>

			</form>";
		}
		?>
		<?php 
		if (isset($_SESSION['login'])) {
			echo "<p style='text-align:center;font-size:20px'>You are logged in!</p>";
		}
		else {
			echo "<p style='text-align:center;font-size:20px;text-color:green;'>You are logged out!</p>";
		}
		?>	
	</div>
</div>
<style>
	div {
		background-image: url("osmaslika.jpg");
	}
	button {

		background-color: #4CAF50;
		color: white;
		padding: 40px 40px;
		margin: 8px 0;
		border: none;
		cursor: pointer;
		width: 40%;
		opacity: 0.9;
	}
	input[type=text], input[type=password], input[type=email] {
		width: 40%;
		padding: 40px;
		margin: 5px 0 22px 0;
		display: inline-block;
		border: none;
		background: #f1f1f1;
	}
	.fb {
		background-color: #3B5998;
		color: white;
	}

	.twitter {
		background-color: #55ACEE;
		color: white;
	}

	.google {
		background-color: #dd4b39;
		color: white;
	}



</style>
<div class="col">
	<a href="#" class="fb btn">
		<i class="fa fa-facebook fa-fw"></i> Login with Facebook
	</a>
	<a href="#" class="twitter btn">
		<i class="fa fa-twitter fa-fw"></i> Login with Twitter
	</a>
	<a href="#" class="google btn"><i class="fa fa-google fa-fw">
	</i> Login with Google+
</a>
</div>
