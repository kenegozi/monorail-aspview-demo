<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>

<form id="new-dvd" action="Save" method="post">
	<div>
		<label for="dvd_Id">Id:</label>
		<input type="text" id="dvd_id" name="Dvd.Id" />
		<br />
		<label for="dvd_Title">Title:</label>
		<input type="text" id="dvd_Title" name="Dvd.Title" />
		<br />
		<label for="dvd_Director">Director:</label>
		<input type="text" id="dvd_Director" name="Dvd.Director" />
		<br />
		<label for="dvd_Year">Year:</label>
		<input type="text" id="dvd_Year" name="Dvd.Year" />
		<br />
		<label for="dvd_Actor1">Actor 1:</label>
		<input type="text" id="dvd_Actor1" name="Dvd.Actors" />
		<br />
		<label for="dvd_Actor2">Actor 2:</label>
		<input type="text" id="dvd_Actor2" name="Dvd.Actors" />
		<br />
		<label for="dvd_Actor3">Actor 3:</label>
		<input type="text" id="dvd_Actor3" name="Dvd.Actors" />
		<br />
		<input type="submit" value="Save" />
	</div>
</form>
