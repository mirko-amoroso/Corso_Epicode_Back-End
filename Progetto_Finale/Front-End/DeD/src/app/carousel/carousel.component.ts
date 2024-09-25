import { Component } from '@angular/core';

@Component({
  selector: 'app-carousel',
  templateUrl: './carousel.component.html',
  styleUrls: ['./carousel.component.scss']
})
export class CarouselComponent {
  currentIndex = 0;
  totalItems = 0;
  autoSlideInterval: any;

  ngOnInit(): void {
    // Setta il numero totale di elementi del carosello
    this.totalItems = document.querySelectorAll('.carousel-item').length;

    // Avvia il carosello automatico
    this.autoSlide();
  }

  showSlide(index: number): void {
    const carouselInner = document.querySelector('.carousel-inner') as HTMLElement;

    if (index >= this.totalItems) {
      this.currentIndex = 0;
    } else if (index < 0) {
      this.currentIndex = this.totalItems - 1;
    } else {
      this.currentIndex = index;
    }

    const offset = -this.currentIndex * 100;
    carouselInner.style.transform = `translateX(${offset}%)`;
  }

  nextSlide(): void {
    this.showSlide(this.currentIndex + 1);
  }

  prevSlide(): void {
    this.showSlide(this.currentIndex - 1);
  }

  autoSlide(): void {
    this.autoSlideInterval = setInterval(() => {
      this.nextSlide();
    }, 3000); // Cambia immagine ogni 3 secondi
  }

  stopAutoSlide(): void {
    clearInterval(this.autoSlideInterval);
  }

  ngOnDestroy(): void {
    this.stopAutoSlide(); // Pulisce l'intervallo quando il componente viene distrutto
  }
}
