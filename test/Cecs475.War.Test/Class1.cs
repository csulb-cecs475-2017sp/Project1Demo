using Xunit;
using Cecs475.War;
using FluentAssertions;

namespace Cecs475.War.Test {
	public class WarPublicTests {
		[Fact]
		public void NewDeckTopCardIsAceOfHearts() {
			Deck d = new Deck();
			Card c = d.DealOne();
			c.Kind.Should().Be(Card.CardKind.Ace, "Ace of Hearts is the top card of a new deck");
			c.Suit.Should().Be(Card.CardSuit.Hearts, "Ace of Hearts is the top card of a new deck");
		}
	}
}
