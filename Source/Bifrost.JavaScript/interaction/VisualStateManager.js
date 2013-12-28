Bifrost.namespace("Bifrost.interaction", {
	VisualStateManager: Bifrost.Type.extend(function() {
		var self = this;

		this.groups = ko.observableArray();
		this.currentState = ko.observable();

		this.addGroup = function(group) {
			self.groups.push(group);
		};
	})
});