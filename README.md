# ExemploInventario

*Sistema simples (parcial) para inventario usando listas e um singleton em Unity.*

Essa cena mostra como usar uma classe `Item` para guardar informações sobre um item e referências ao prefab que será usado para mostrar esse item em uma interface gráfica (UI) para o jogador. 

Quando o item for "pego" na cena (usando o componente `ItemClicavel`), ele vai para o menu de inventário, para depois ser utilizado.

Quando o item for selecionado no menu, ele altera o cursor do gerenciador `Jogo` para ter o seu nome. Isso pode ser usado depois para lógicas condicionais nos `GameObject`s da cena.

O `Jogo` é um [singleton](http://gameprogrammingpatterns.com/singleton.html) que guarda informações globais sobre o estado do jogo e pode servir como central para uma série de funcionalidades, no caso, o cursor do mouse.
