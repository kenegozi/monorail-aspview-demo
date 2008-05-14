<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>

<form id="new-dvd" action="Save.demo" method="post">
	<div>
		<label for="dvd_Id">Id:</label>
		<input type="text" id="dvd_id" name="dvd.Id" />
		<br />
		<label for="dvd_Title">Title:</label>
		<input type="text" id="dvd_Title" name="dvd.Title" />
		<br />
		<label for="dvd_Director">Director:</label>
		<input type="text" id="dvd_Director" name="dvd.Director" />
		<br />
		<label for="dvd_Year">Year:</label>
		<input type="text" id="dvd_Year" name="dvd.Year" />
		<br />
		<label for="dvd_Actor1">Actor 1:</label>
		<input type="text" id="dvd_Actor1" name="dvd.Actors[0]" />
		<br />
		<label for="dvd_Actor2">Actor 2:</label>
		<input type="text" id="dvd_Actor2" name="dvd.Actors[1]" />
		<br />
		<label for="dvd_Actor3">Actor 3:</label>
		<input type="text" id="dvd_Actor3" name="dvd.Actors[2]" />
		<br />
		<input type="submit" value="Save" />
	</div>
</form>
