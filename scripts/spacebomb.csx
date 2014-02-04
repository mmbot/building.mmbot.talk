var robot = Require<Robot>();

robot.Respond(@"space bomb", msg => {
	msg.Send(string.Join(Environment.NewLine, Enumerable.Range(0, 50).Select(_ => "...").ToArray()));
});