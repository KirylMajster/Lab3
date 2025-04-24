Sprawozdanie – Lab3 (.NET + Windows Forms + wielowątkowość)

Lab3 to aplikacja stworzona w technologii Windows Forms (.NET 8), która umożliwia:

- mnożenie macierzy na trzy sposoby: sekwencyjnie, z użyciem Parallel oraz z użyciem Thread,
- wybór rozmiaru macierzy i liczby wątków,
- pomiar czasu każdego podejścia i jego porównanie,
- zapis wyników benchmarku do pliku CSV,
- przetwarzanie obrazów graficznych w osobnych wątkach (Zadanie 3).

Struktura aplikacji

Aplikacja składa się z następujących klas:

- **MatrixGenerator** – generuje losowe macierze o podanym rozmiarze.
- **MatrixMultiplier** – zawiera trzy metody:
  - MultiplySequential – klasyczne potójne pętle,
  - MultiplyParallel – wykorzystuje Parallel.For,
  - MultiplyWithThreads – tworzy własne wątki i dzieli wiersze ręcznie.
- **BenchmarkManager** – wykonuje serie testów i zapisuje średnie czasy do pliku.
- **Form1** – interfejs graficzny umożliwiający wybór danych wejściowych i uruchomienie benchmarku.

Działanie algorytmów

Po kliknięciu "Uruchom" generowane są dwie macierze A i B. Następnie są mnożone:
- sekwencyjnie (jedna pętla i jeden wątek),
- z użyciem Parallel.For, gdzie każdy wiersz przetwarzany jest przez osobny wątek z systemowego poola,
- z użyciem ręcznych Thread, gdzie program samodzielnie dzieli zakres wierszy na liczbę wątków i uruchamia każdy oddzielnie.

Benchmark

Przy pomocy BenchmarkManagera wykonano pomiar czasu trzech metod dla macierzy o rozmiarach 100, 200, 300, 500 i 700, przy liczbie wątków: 1, 2, 4, 6, 8, 10, 12.
Każdy pomiar był wykonywany 5 razy i liczono średnią.

Plik CSV zawiera kolumny:
- Size
- Threads
- Avg_Sequential(ms)
- Avg_Parallel(ms)
- Avg_Thread(ms)

Analiza wyników

- Dla małych macierzy (100, 200) różnica między metodami jest niewielka, a zbyt dużo wątków może wręcz spowolnić przetwarzanie.
- Przy większych rozmiarach (500, 700) Parallel wypada najlepiej, szczególnie przy 6–8 wątkach.
- Metoda Thread również przyspiesza obliczenia, ale nieznacznie ustępuje Parallel, ponieważ wymaga ręcznego zarządzania.
- Sekwencyjna metoda jest najwolniejsza, ale stanowi dobry punkt odniesienia.

Zapis danych

Wyniki zapisywane są do pliku benchmark_results.csv, który można otworzyć w Excelu i wygenerować wykresy.
Dla poprawnej interpretacji w polskim Excelu zastosowano separator `;`.

Zadanie 3 – przetwarzanie obrazów

W trzecim zadaniu rozszerzono aplikację o możliwość przetwarzania obrazów graficznych (plików .jpg/.png) z wykorzystaniem wielowątkowości. 
Użytkownik może wczytać obrazek, który zostaje przetworzony przez cztery niezależne wątki, z których każdy stosuje inny filtr:

- konwersja do odcieni szarości (grayscale),
- negatyw,
- progowanie (threshold),
- odbicie lustrzane w poziomie (mirror).

Dla każdego filtru tworzona jest osobna kopia obrazu. Funkcja `ApplyFilter` iteruje po pikselach i przekształca obraz zgodnie z wybranym typem filtra. 
Wszystkie operacje przetwarzania odbywają się w niezależnych wątkach, co poprawia wydajność i zapewnia płynność działania aplikacji. 
Efekty filtrowania prezentowane są w oddzielnych polach graficznych (PictureBox) wraz z podpisami.

Wnioski

Najlepsze efekty daje użycie Parallel.For, zwłaszcza przy dużych macierzach i rozsądnej liczbie wątków (4–8). Wersja Thread również jest szybka, ale bardziej kodochłonna. Sekwencyjna wersja działa poprawnie, ale jest najwolniejsza i nie wykorzystuje zalet procesorów wielordzeniowych. 
Z kolei przetwarzanie obrazu przy użyciu równoległych wątków pozwala na szybką prezentację kilku niezależnych efektów graficznych bez zawieszania interfejsu użytkownika.

