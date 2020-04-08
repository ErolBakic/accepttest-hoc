window.addEventListener('DOMContentLoaded', () => {

  // Mobile nav
  let toggled     = false;
  const toggleBtn = document.querySelector('#toggle-nav');
  const menu      = document.querySelector('#top-menu');
  let icon        = toggleBtn.querySelector('path');

  const newShape = 'M193.94 256L296.5 153.44l21.15-21.15c3.12-3.12 3.12-8.19 0-11.31l-22.63-22.63c-3.12-3.12-8.19-3.12-11.31 0L160 222.06 36.29 98.34c-3.12-3.12-8.19-3.12-11.31 0L2.34 120.97c-3.12 3.12-3.12 8.19 0 11.31L126.06 256 2.34 379.71c-3.12 3.12-3.12 8.19 0 11.31l22.63 22.63c3.12 3.12 8.19 3.12 11.31 0L160 289.94 262.56 392.5l21.15 21.15c3.12 3.12 8.19 3.12 11.31 0l22.63-22.63c3.12-3.12 3.12-8.19 0-11.31L193.94 256z';
  const oldShape = icon.getAttribute('d');

  const toggleNav = () => {
    if(toggled == false){
      menu.classList.add('menu--active');
      icon.setAttribute('d', newShape);

      toggled = true;
    } else {
      menu.classList.remove('menu--active');
      icon.setAttribute('d', oldShape);

      toggled = false;
    }
  }
  toggleBtn.addEventListener('click', toggleNav);

  // Form autofocus
  const form = document.querySelector('form');
  if(form){
    form.querySelector('.form-control').focus();
  }

});
