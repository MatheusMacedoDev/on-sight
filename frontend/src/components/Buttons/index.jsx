"use client"

import React, { useState } from "react";
import { FaPaperPlane, FaPlus } from "react-icons/fa";
import { TextButton } from "../Texts";

const delay = ms => new Promise(res => setTimeout(res, ms));

export const ButtonAzul = ({ text, onClick, ...rest}) => {
  const [isLoading, setIsLoading] = useState(false);

  return (
    <div className="w-full flex justify-center">
      <button
        className="w-full max-w-[400px] h-auto p-3 bg-gradient-to-b transition-all from-[#03558c] to-[#124262] hover:from-[#124262] hover:to-[#124262] rounded-lg text-white font-nunito-bold flex justify-center items-center"
        onClick={async () => {
          setIsLoading(true);

          await onClick();

          await delay(200);

          setIsLoading(false);
        }}
        { ...rest }
        disabled={isLoading}
      >
        {isLoading ? (
          <svg aria-hidden="true" class="w-5 h-5 text-gray-200 animate-spin dark:text-gray-600 fill-[#142937]" viewBox="0 0 100 101" fill="none" xmlns="http://www.w3.org/2000/svg">
            <path d="M100 50.5908C100 78.2051 77.6142 100.591 50 100.591C22.3858 100.591 0 78.2051 0 50.5908C0 22.9766 22.3858 0.59082 50 0.59082C77.6142 0.59082 100 22.9766 100 50.5908ZM9.08144 50.5908C9.08144 73.1895 27.4013 91.5094 50 91.5094C72.5987 91.5094 90.9186 73.1895 90.9186 50.5908C90.9186 27.9921 72.5987 9.67226 50 9.67226C27.4013 9.67226 9.08144 27.9921 9.08144 50.5908Z" fill="currentColor"/>
            <path d="M93.9676 39.0409C96.393 38.4038 97.8624 35.9116 97.0079 33.5539C95.2932 28.8227 92.871 24.3692 89.8167 20.348C85.8452 15.1192 80.8826 10.7238 75.2124 7.41289C69.5422 4.10194 63.2754 1.94025 56.7698 1.05124C51.7666 0.367541 46.6976 0.446843 41.7345 1.27873C39.2613 1.69328 37.813 4.19778 38.4501 6.62326C39.0873 9.04874 41.5694 10.4717 44.0505 10.1071C47.8511 9.54855 51.7191 9.52689 55.5402 10.0491C60.8642 10.7766 65.9928 12.5457 70.6331 15.2552C75.2735 17.9648 79.3347 21.5619 82.5849 25.841C84.9175 28.9121 86.7997 32.2913 88.1811 35.8758C89.083 38.2158 91.5421 39.6781 93.9676 39.0409Z" fill="currentFill"/>
          </svg>
        ) : text}
      </button>
    </div>
  );
};


export const ButtonAzul2 = ({ text, onClick, ...rest}) => {
  return (
    <div className="w-full flex justify-center">
      <button
        className="w-full max-w-[400px] h-auto p-3 bg-gradient-to-b transition-all from-[#03558c] to-[#124262] hover:from-[#124262] hover:to-[#124262] rounded-lg text-white font-nunito-bold flex justify-center items-center"
        { ...rest }
      >
        { text }
      </button>
    </div>
  );
};


export const ButtonCancelar = ({ text, ...props }) => {
  return (
    <button type="button" className="text-[16px] text-[#124262] font-nunito-bold" { ...props }>
      Cancelar
    </button>
  );
};

export const ButtonAddUser = (props) => {
  return (
    <button
      onClick={props.onClick}
      className="transition-all scale-100 hover:scale-[1.02] bg-gradient-to-t from-[#124262] to-[#03558C] hover:from-[#124262] hover:to-[#144b70] text-white w-[25%] h-auto px-4 py-2 rounded-md flex items-center justify-center space-x-2"
    >
      <FaPlus />{" "}
      <TextButton additionalClasses="md:text-[18px] max-sm:text-[10px]">
        Novo Usuário
      </TextButton>
    </button>
  );
};

export const ToggleButton = () => {
  const [isToggled, setIsToggled] = useState(false);

  const toggleButton = () => {
    setIsToggled(!isToggled);
  };

  return (
    <button
      onClick={toggleButton}
      className={`w-8 h-5 rounded-full border-2 ${
        isToggled ? "bg-[#142937]" : "bg-white"
      } border-[#142937] relative transition-colors duration-200 ease-in-out`}
    >
      <div
        className={`w-3 h-3 rounded-full bg-[#142937] absolute top-1 left-1 transition-transform duration-200 ease-in-out ${
          isToggled ? "transform translate-x-3" : ""
        }`}
      ></div>
    </button>
  );
};

export const GradientButton = () => {
  return (
    <button className="flex items-center justify-center w-[468px] h-[61.48px] bg-gradient-to-b from-[#03558c] to-[#124262] rounded-[10px] gap-2">
      <FaPaperPlane className="text-white text-[22px]" />
      <span className="text-white text-xl font-bold font-nunito">
        Enviar
      </span>
    </button>
  );
};
