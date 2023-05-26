namespace UI.Console.Enums;

public enum ComponentId
{
	// REST API CRUD buttons.
	PostGameButton,
	GetGameButton,
	GetGamesButton,
	PlayGameButton,
	PutGameButton,
	// Anchors with href values.
	GoToGameNewPageAnchor,
	GoToGamesPageAnchor,
	GoToHomePageAnchor,
	GoToPlaygroundPageAnchor,
	// Sections.
	GridSection,
	// Other buttons.
	PauseGameButton,
	QuitGameButton,
	// Inputs.
	InputWithLabel,
	GameNameInput,
	CellPositionInput,
	GridAreaInput,
	// Forms.
	NewGameForm,
	// Pages are a components here.
	HomePage,
	GameNewPage,
	GamesPage,
	PlaygroundPage,
	// Navbars.
	HomeNavBar,
	GameNewNavBar,
	GamesNavBar,
	PlaygroundNavBar,
	// Invalid components.
	InvalidComponentId
}