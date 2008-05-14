<%@ Page Language="C#" Inherits="Castle.MonoRail.Views.AspView.ViewAtDesignTime" %>

item name: <input type="text" name="q" id="q" />
<input type="button" id="send" value="add item" />

<br />

<div id="container">
</div>

<script type="text/javascript">

Event.observe(window, 'load', function() {

	Event.observe('send', 'click', function() {
		var q = $('q').value;
		new Ajax.Request('/lendables/index.demo?q=' + q, {
			onSuccess :function(t) {
				$('container').update(t.responseText);
			}
		});
	});


});



</script>