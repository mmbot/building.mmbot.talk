var robot = Require<Robot>();

robot.Router.Post("announce/{adapter}/{room}", context => {
	var adapter = context.Request.Params()["adapter"];
	var room = context.Request.Params()["room"];
	var message = context.ReadBodyAsString();

	robot.Speak(adapter, room, message.Trim());
});